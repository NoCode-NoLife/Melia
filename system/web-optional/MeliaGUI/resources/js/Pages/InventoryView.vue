<script setup>
import { onMounted, ref, toRef, getCurrentInstance } from 'vue'
import { useStore } from 'vuex'
import { Head, useForm } from '@inertiajs/vue3'
import {
  mdiArchive,
  mdiMagnify,
  mdiAccount,
  mdiCardAccountDetailsOutline,
  mdiCircle,
} from '@mdi/js'
import CardBox from '@/components/CardBox.vue'
import FormField from '@/components/FormField.vue'
import FormControl from '@/components/FormControl.vue'
import InputError from '@/Components/InputError.vue'
import SectionMain from '@/components/SectionMain.vue'
import LayoutAuthenticated from '../Layouts/LayoutAuthenticated.vue'
import SectionTitleLine from '@/components/SectionTitleLine.vue'
import NotificationBar from '@/components/NotificationBar.vue'
import BaseDivider from '@/components/BaseDivider.vue'
import OverlayLayer from '@/components/OverlayLayer.vue'
import TableItems from '@/components/TableItems.vue'
import BaseIcon from '@/components/BaseIcon.vue'

const props = defineProps({
  account: {
    type: Object,
    required: true,
  },
  isServerOnline: {
    type: Boolean,
    required: true,
  },
  items: {
    type: Array,
    required: true,
  },
  status: {
    type: Object,
  },
})

const isLoading = ref(false)
const notificationIcon = ref('')

const store = useStore()
const instance = getCurrentInstance()
const accountRef = toRef(instance.props, 'account')

const form = useForm({
  teamName: '',
})

const postForm = () => {
  isLoading.value = true
  form.post(route('admin.inventory.manager.search'), {
    preserveScroll: true,
    onSuccess: () => (isLoading.value = false),
    onFinish: () => (isLoading.value = false),
  })
}

const startLoading = () => {
  isLoading.value = true
}

const stopLoading = () => {
  isLoading.value = false
}

onMounted(() => {
  store.commit('setAccount', accountRef.value)
})

if (props.status != null) {
  switch (props.status.type) {
    case 'info':
      notificationIcon.value = mdiInformation
    case 'success':
      notificationIcon.value = mdiCheckCircle
    case 'warning':
      notificationIcon.value = mdiAlert
    case 'danger':
      notificationIcon.value = mdiAlertCircle
  }
}
</script>

<template>
  <Head title="Inventory" />

  <OverlayLayer
    v-show="isLoading"
    @wheel.prevent
    @touchmove.prevent
    @scroll.prevent
  >
    <div role="status">
      <svg
        aria-hidden="true"
        class="inline w-8 h-8 mr-2 text-gray-200 animate-spin dark:text-gray-600 fill-green-500"
        viewBox="0 0 100 101"
        fill="none"
        xmlns="http://www.w3.org/2000/svg"
      >
        <path
          d="M100 50.5908C100 78.2051 77.6142 100.591 50 100.591C22.3858 100.591 0 78.2051 0 50.5908C0 22.9766 22.3858 0.59082 50 0.59082C77.6142 0.59082 100 22.9766 100 50.5908ZM9.08144 50.5908C9.08144 73.1895 27.4013 91.5094 50 91.5094C72.5987 91.5094 90.9186 73.1895 90.9186 50.5908C90.9186 27.9921 72.5987 9.67226 50 9.67226C27.4013 9.67226 9.08144 27.9921 9.08144 50.5908Z"
          fill="currentColor"
        />
        <path
          d="M93.9676 39.0409C96.393 38.4038 97.8624 35.9116 97.0079 33.5539C95.2932 28.8227 92.871 24.3692 89.8167 20.348C85.8452 15.1192 80.8826 10.7238 75.2124 7.41289C69.5422 4.10194 63.2754 1.94025 56.7698 1.05124C51.7666 0.367541 46.6976 0.446843 41.7345 1.27873C39.2613 1.69328 37.813 4.19778 38.4501 6.62326C39.0873 9.04874 41.5694 10.4717 44.0505 10.1071C47.8511 9.54855 51.7191 9.52689 55.5402 10.0491C60.8642 10.7766 65.9928 12.5457 70.6331 15.2552C75.2735 17.9648 79.3347 21.5619 82.5849 25.841C84.9175 28.9121 86.7997 32.2913 88.1811 35.8758C89.083 38.2158 91.5421 39.6781 93.9676 39.0409Z"
          fill="currentFill"
        />
      </svg>
      <span class="sr-only">Loading...</span>
    </div>
  </OverlayLayer>

  <LayoutAuthenticated>
    <SectionMain>
      <NotificationBar
        v-if="props.status"
        :color="props.status.type"
        :icon="notificationIcon"
        :outline="false"
      >
        {{ props.status.message }}
      </NotificationBar>

      <SectionTitleLine :icon="mdiArchive" title="Inventory" main>
      </SectionTitleLine>
      <div class="flex flex-col gap-4">
        <div class="mb-6">
          <CardBox is-form @submit.prevent="postForm">
            <InputError class="m-2" :message="form.errors.teamName" />
            <FormField
              label="TeamName"
              help="Please enter the team name."
              class="w-96"
            >
              <FormControl
                v-model="form.teamName"
                :icon="mdiMagnify"
                name="teamName"
                autocomplete="teamName"
              />
            </FormField>
          </CardBox>

          <CardBox v-if="Object.keys(items).length > 0" class="mt-4 mb-4">
            <div v-for="(value, teamName) in items" :key="teamName">
              <SectionTitleLine
                :icon="mdiCardAccountDetailsOutline"
                :title="teamName"
              >
              </SectionTitleLine>
              <div
                class="border rounded-lg border-gray-500 m-5 p-5"
                v-for="(items, characterName) in value"
                :key="characterName"
              >
                <SectionTitleLine :icon="mdiAccount" :title="characterName">
                  <BaseIcon
                    :path="mdiCircle"
                    :class="[
                      items[0].isCharacterOnline && isServerOnline
                        ? 'text-green-500'
                        : 'text-red-500',
                    ]"
                    w="w-16"
                    :size="18"
                  />
                </SectionTitleLine>

                <TableItems
                  :items="items"
                  :startLoading="startLoading"
                  :stopLoading="stopLoading"
                  :isServerOnline="isServerOnline"
                />
              </div>
            </div>
          </CardBox>

          <BaseDivider />
        </div>
      </div>
    </SectionMain>
  </LayoutAuthenticated>
</template>
