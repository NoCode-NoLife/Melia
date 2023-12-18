<script setup>
import { reactive, getCurrentInstance, toRef, onMounted } from 'vue'
import {
  mdiAccount,
  mdiMail,
  mdiAsterisk,
  mdiFormTextboxPassword,
  mdiCardAccountDetailsStar,
  mdiAccountBox,
} from '@mdi/js'
import SectionMain from '@/components/SectionMain.vue'
import CardBox from '@/components/CardBox.vue'
import BaseDivider from '@/components/BaseDivider.vue'
import FormField from '@/components/FormField.vue'
import FormControl from '@/components/FormControl.vue'
import BaseButton from '@/components/BaseButton.vue'
import UserCard from '@/components/UserCard.vue'
import LayoutAuthenticated from '../Layouts/LayoutAuthenticated.vue'
import SectionTitleLine from '@/components/SectionTitleLine.vue'
import { Head, Link, useForm } from '@inertiajs/vue3'
import NotificationBar from '@/components/NotificationBar.vue'
import InputError from '@/Components/InputError.vue'
import { useStore } from 'vuex'

defineProps({
  user: {
    type: Object,
    required: true,
  },
  account: {
    type: Object,
    required: true,
  },
  mustVerifyEmail: {
    type: Boolean,
  },
  status: {
    type: String,
  },
})

const store = useStore()
const instance = getCurrentInstance()
const accountRef = toRef(instance.props, 'account')

onMounted(() => {
  store.commit('setAccount', accountRef.value)
})

const passwordForm = reactive({
  password_current: '',
  password: '',
  password_confirmation: '',
})

const form = useForm({
  email: instance.props.user.email,
  teamName: instance.props.account.teamName,
  name: instance.props.account.name,
})

const formPass = useForm({
  current_password: '',
  password: '',
  password_confirmation: '',
})

const updatePassword = () => {
  formPass.put(route('password.update'), {
    preserveScroll: true,
    onSuccess: () => formPass.reset(),
    onError: () => {
      if (formPass.errors.password) {
        formPass.reset('password', 'password_confirmation')
      }
      if (formPass.errors.current_password) {
        formPass.reset('current_password')
      }
    },
  })
}
</script>

<template>
  <Head title="Profile" />
  <LayoutAuthenticated>
    <SectionMain>
      <SectionTitleLine :icon="mdiAccount" title="Profile" main>
      </SectionTitleLine>

      <UserCard class="mb-6" />

      <div v-if="mustVerifyEmail && user.email_verified_at === null">
        <NotificationBar
          color="info"
          :icon="mdiInformation"
          :outline="notificationsOutline"
        >
          <b>Your email address is unverified.</b>
          <br />
          <Link
            :href="route('verification.send')"
            method="post"
            as="button"
            class="hover:text-gray-900 rounded-md focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
          >
            Click here to re-send the verification email.
          </Link>
        </NotificationBar>
        <NotificationBar
          v-show="status === 'verification-link-sent'"
          color="success"
          :icon="mdiCheckCircle"
          :outline="notificationsOutline"
        >
          A new verification link has been sent to your email address.
        </NotificationBar>
      </div>

      <div class="grid grid-cols-1 lg:grid-cols-2 gap-6">
        <CardBox is-form @submit.prevent="form.patch(route('profile.update'))">
          <FormField label="login" help="Your account login.">
            <FormControl
              v-model="form.name"
              :disabled="true"
              :icon="mdiAccountBox"
              name="name"
              required
              autocomplete="login"
            />
          </FormField>
          <FormField label="Team Name" help="Your Team Name.">
            <FormControl
              v-model="form.teamName"
              :disabled="true"
              :icon="mdiCardAccountDetailsStar"
              name="teamName"
              required
              autocomplete="teamName"
            />
          </FormField>
          <FormField label="E-mail" help="Required. Your e-mail">
            <FormControl
              v-model="form.email"
              :icon="mdiMail"
              type="email"
              name="email"
              required
              autocomplete="email"
            />
          </FormField>

          <InputError :message="form.errors.email" class="mt-2" />

          <Transition
            enter-active-class="transition ease-in-out"
            enter-from-class="opacity-0"
            leave-active-class="transition ease-in-out"
            leave-to-class="opacity-0"
          >
            <p v-if="form.recentlySuccessful" class="text-sm text-gray-600">
              Saved.
            </p>
          </Transition>

          <template #footer>
            <BaseButton color="info" type="submit" label="Submit" />
          </template>
        </CardBox>

        <CardBox is-form @submit.prevent="updatePassword">
          <InputError
            :message="formPass.errors.current_password"
            class="mt-2"
          />
          <FormField
            label="Current password"
            help="Required. Your current password"
          >
            <FormControl
              v-model="formPass.current_password"
              :icon="mdiAsterisk"
              name="current_password"
              type="password"
              required
              autocomplete="current_password"
            />
          </FormField>

          <BaseDivider />

          <InputError :message="formPass.errors.password" class="mt-2" />

          <FormField label="New password" help="Required. New password">
            <FormControl
              v-model="formPass.password"
              :icon="mdiFormTextboxPassword"
              name="password"
              type="password"
              required
              autocomplete="password"
            />
          </FormField>

          <InputError
            :message="formPass.errors.password_confirmation"
            class="mt-2"
          />

          <FormField
            label="Confirm password"
            help="Required. New password one more time"
          >
            <FormControl
              v-model="formPass.password_confirmation"
              :icon="mdiFormTextboxPassword"
              name="password_confirmation"
              type="password"
              required
              autocomplete="password_confirmation"
            />
          </FormField>

          <Transition
            enter-active-class="transition ease-in-out"
            enter-from-class="opacity-0"
            leave-active-class="transition ease-in-out"
            leave-to-class="opacity-0"
          >
            <p v-if="form.recentlySuccessful" class="text-sm text-gray-600">
              Password Updated.
            </p>
          </Transition>

          <template #footer>
            <BaseButton color="info" type="submit" label="Submit" />
          </template>
        </CardBox>
      </div>
    </SectionMain>
  </LayoutAuthenticated>
</template>
