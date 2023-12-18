<script setup>
import { mdiAccount, mdiAsterisk } from '@mdi/js'
import SectionFullScreen from '@/components/SectionFullScreen.vue'
import CardBox from '@/components/CardBox.vue'
import FormCheckRadio from '@/components/FormCheckRadio.vue'
import FormField from '@/components/FormField.vue'
import FormControl from '@/components/FormControl.vue'
import BaseButton from '@/components/BaseButton.vue'
import LayoutGuest from '../Layouts/LayoutGuest.vue'
import InputError from '@/Components/InputError.vue'
import { Head, useForm, Link } from '@inertiajs/vue3'

defineProps({
  canResetPassword: {
    type: Boolean,
  },
  status: {
    type: String,
  },
})

const form = useForm({
  login: '',
  password: '',
  remember: false,
})

const passwordRoute = route('password.request')

const submit = () => {
  form.post(route('login'), {
    onFinish: () => form.reset('password'),
  })
}
</script>

<template>
  <Head title="Login" />
  <LayoutGuest>
    <SectionFullScreen v-slot="{ cardClass }" bg="purplePink">
      <div class="flex flex-col items-center w-full">
        <img src="/assets/img/logo_white.png" class="-mt-8 mb-4" />
        <div class="w-full flex items-center justify-center">
          <CardBox
            :class="cardClass"
            marginbottomzero
            is-form
            @submit.prevent="submit"
          >
            <InputError class="m-2" :message="form.errors.login" />
            <InputError class="m-2" :message="form.errors.password" />
            <div v-if="status" class="font-medium text-sm text-green-600">
              {{ status }}
            </div>
            <FormField label="Login" help="Please enter your login">
              <FormControl
                v-model="form.login"
                :icon="mdiAccount"
                name="login"
                autocomplete="username"
              />
            </FormField>

            <FormField label="Password" help="Please enter your password">
              <FormControl
                v-model="form.password"
                :icon="mdiAsterisk"
                type="password"
                name="password"
                autocomplete="current-password"
              />
            </FormField>

            <FormCheckRadio
              v-model="form.remember"
              name="remember"
              label="Remember"
              :input-value="true"
            />

            <div class="flex justify-between">
              <Link
                v-if="canResetPassword"
                :href="passwordRoute"
                class="underline text-sm text-gray-600 rounded-md focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
              >
                Forgot your password?
              </Link>
            </div>
            <template #footer>
              <div class="flex items-center">
                <BaseButton
                  type="submit"
                  color="info"
                  label="Login"
                  :disabled="form.processing"
                />
              </div>
            </template>
          </CardBox>
        </div>
      </div>
    </SectionFullScreen>
  </LayoutGuest>
</template>
