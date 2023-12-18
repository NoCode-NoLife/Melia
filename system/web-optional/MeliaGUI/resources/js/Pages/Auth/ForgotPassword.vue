<script setup>
import { mdiEmail } from '@mdi/js'
import SectionFullScreen from '@/components/SectionFullScreen.vue'
import CardBox from '@/components/CardBox.vue'
import FormField from '@/components/FormField.vue'
import FormControl from '@/components/FormControl.vue'
import BaseButton from '@/components/BaseButton.vue'
import LayoutGuest from '../../Layouts/LayoutGuest.vue'
import BaseButtons from '@/components/BaseButtons.vue'
import InputError from '@/Components/InputError.vue'
import { Head, useForm } from '@inertiajs/vue3'

defineProps({
  status: {
    type: String,
  },
})

const routeHome = route('home')

const form = useForm({
  email: '',
})

const submit = () => {
  form.post(route('password.email'))
}
</script>

<template>
  <Head title="Login" />
  <LayoutGuest>
    <SectionFullScreen v-slot="{ cardClass }" bg="purplePink">
      <CardBox
        :class="cardClass"
        marginbottomzero
        is-form
        @submit.prevent="submit"
      >
        <div v-if="status" class="font-medium text-sm text-green-600 mb-2">
          {{ status }}
        </div>

        <InputError
          class="font-medium text-sm text-green-600 mb-2"
          :message="form.errors.email"
        />

        <div class="text-sm text-gray-600">
          Forgot your password? No problem. Just let us know your email address
          and we will email you a password reset link that will allow you to
          choose a new one.
        </div>

        <FormField label="Email" help="Please enter your email">
          <FormControl
            v-model="form.email"
            :icon="mdiEmail"
            name="email"
            autocomplete="email"
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
