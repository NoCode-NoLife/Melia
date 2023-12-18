<script setup>
import { mdiLock, mdiFormTextboxPassword, mdiEmail } from '@mdi/js'
import { Head, useForm } from '@inertiajs/vue3'
import InputError from '@/Components/InputError.vue'
import SectionFullScreen from '@/components/SectionFullScreen.vue'
import CardBox from '@/components/CardBox.vue'
import FormField from '@/components/FormField.vue'
import FormControl from '@/components/FormControl.vue'
import BaseButton from '@/components/BaseButton.vue'
import LayoutGuest from '../../Layouts/LayoutGuest.vue'
import BaseButtons from '@/components/BaseButtons.vue'

const props = defineProps({
  email: {
    type: String,
    required: true,
  },
  token: {
    type: String,
    required: true,
  },
})

const routeHome = route('home')

const form = useForm({
  token: props.token,
  email: props.email,
  password: '',
  password_confirmation: '',
})

const submit = () => {
  form.post(route('password.store'), {
    onFinish: () => form.reset('password', 'password_confirmation'),
  })
}
</script>

<template>
  <Head title="Reset Password" />
  <LayoutGuest>
    <SectionFullScreen v-slot="{ cardClass }" bg="purplePink">
      <CardBox
        :class="cardClass"
        marginbottomzero
        is-form
        @submit.prevent="submit"
      >
        <InputError class="mt-2" :message="form.errors.password_confirmation" />
        <InputError class="mt-2" :message="form.errors.password" />
        <InputError class="mt-2" :message="form.errors.email" />
        <InputError class="mt-2" :message="form.errors.token" />

        <FormField label="Email" help="Please enter your email">
          <FormControl
            v-model="form.email"
            :icon="mdiEmail"
            name="email"
            autocomplete="email"
          />
        </FormField>

        <FormField label="New Password" help="Please enter your new password">
          <FormControl
            v-model="form.password"
            :icon="mdiFormTextboxPassword"
            name="password"
            type="password"
            autocomplete="new_password"
          />
        </FormField>

        <FormField
          label="Password Confirmation"
          help="Please enter the password confirmation"
        >
          <FormControl
            v-model="form.password_confirmation"
            :icon="mdiLock"
            type="password"
            name="password_confirmation"
            autocomplete="password_confirmation"
          />
        </FormField>

        <template #footer>
          <BaseButtons>
            <BaseButton
              type="submit"
              color="info"
              label="Reset Password"
              :class="{ 'opacity-25': form.processing }"
              :disabled="form.processing"
            />
            <BaseButton
              color="info"
              label="Back"
              :href="routeHome"
              outline
              :class="{ 'opacity-25': form.processing }"
              :disabled="form.processing"
            />
          </BaseButtons>
        </template>
      </CardBox>
    </SectionFullScreen>
  </LayoutGuest>
</template>
