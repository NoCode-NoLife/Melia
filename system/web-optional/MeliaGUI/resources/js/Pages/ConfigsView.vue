<script setup>
import { onMounted, toRef, getCurrentInstance, ref, reactive } from 'vue'
import {
  mdiChevronRight,
  mdiChevronLeft,
  mdiContentSave,
  mdiCog,
  mdiInformation,
  mdiCheckCircle,
  mdiAlert,
  mdiAlertCircle,
} from '@mdi/js'
import { useStore } from 'vuex'
import { Head, router } from '@inertiajs/vue3'
import SectionMain from '@/components/SectionMain.vue'
import LayoutAuthenticated from '../Layouts/LayoutAuthenticated.vue'
import SectionTitleLine from '@/components/SectionTitleLine.vue'
import FormField from '@/components/FormField.vue'
import BaseDivider from '@/components/BaseDivider.vue'
import CardBox from '@/components/CardBox.vue'
import BaseButtons from '@/components/BaseButtons.vue'
import BaseButton from '@/components/BaseButton.vue'
import FormControl from '@/components/FormControl.vue'
import OverlayLayer from '@/components/OverlayLayer.vue'
import NotificationBar from '@/components/NotificationBar.vue'

const props = defineProps({
  account: {
    type: Object,
    required: true,
  },
  configs: {
    type: Object,
    required: true,
  },
  backupSchedule: {
    type: Number,
    required: true,
  },
  enableTrading: {
    type: String,
    required: true,
  },
  isServerOnline: {
    type: Boolean,
    required: true,
  },
  status: {
    type: Object,
  },
})

const store = useStore()
const instance = getCurrentInstance()
const accountRef = toRef(instance.props, 'account')
const isLoading = ref(false)
const notificationIcon = ref('')

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

onMounted(() => {
  store.commit('setAccount', accountRef.value)
})

const scheduleOptions = [
  { id: 1, label: 'Disabled' },
  { id: 2, label: 'Daily' },
  { id: 3, label: 'Weekly' },
  { id: 4, label: 'Monthly' },
]

const enableOrDisableOptions = [
  { id: 1, label: 'Disabled' },
  { id: 2, label: 'Enabled' },
]

const state = reactive({
  currentIndex: 0,
  pageTitles: [
    'World Configs',
    'Web Configs',
    'Barracks Configs',
    'Database Configs',
    'Commands Configs',
    'Log Configs',
    'Localization Configs',
  ],
})

const slidePrev = () => {
  state.currentIndex = Math.max(state.currentIndex - 1, 0)
}

const slideNext = () => {
  state.currentIndex = Math.min(
    state.currentIndex + 1,
    state.pageTitles.length - 1,
  )
}

const selectConfig = (configIndex) => {
  state.currentIndex = configIndex
}

const saveConfigs = () => {
  isLoading.value = true

  const worldConfigs = Object.keys(instance.props.configs.world).reduce(
    (acc, key) => {
      const { value } = instance.props.configs.world[key]
      acc[key] = value
      return acc
    },
    {},
  )

  const barracksConfigs = Object.keys(instance.props.configs.barracks).reduce(
    (acc, key) => {
      const { value } = instance.props.configs.barracks[key]
      acc[key] = value
      return acc
    },
    {},
  )

  const webConfigs = Object.keys(instance.props.configs.web).reduce(
    (acc, key) => {
      const { value } = instance.props.configs.web[key]
      acc[key] = value
      return acc
    },
    {},
  )

  const databaseConfigs = Object.keys(instance.props.configs.database).reduce(
    (acc, key) => {
      const { value } = instance.props.configs.database[key]
      acc[key] = value
      return acc
    },
    {},
  )

  const commandsConfigs = Object.keys(instance.props.configs.commands).reduce(
    (acc, key) => {
      const { value } = instance.props.configs.commands[key]
      acc[key] = value
      return acc
    },
    {},
  )

  const logConfigs = Object.keys(instance.props.configs.log).reduce(
    (acc, key) => {
      const { value } = instance.props.configs.log[key]
      acc[key] = value
      return acc
    },
    {},
  )

  const localizationConfigs = Object.keys(
    instance.props.configs.localization,
  ).reduce((acc, key) => {
    const { value } = instance.props.configs.localization[key]
    acc[key] = value
    return acc
  }, {})

  const mergedConfigs = {
    barracks: barracksConfigs,
    world: worldConfigs,
    web: webConfigs,
    database: databaseConfigs,
    commands: commandsConfigs,
    log: logConfigs,
    localization: localizationConfigs,
  }

  console.log(mergedConfigs)

  router.post(route('admin.configs.update'), mergedConfigs, {
    preserveState: false,
    preserveScroll: true,
    onSuccess: (page) => {
      isLoading.value = false
    },
  })
}
</script>

<template>
  <Head title="Server Configs" />

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

      <CardBox v-if="!isServerOnline" class="mb-5">
        <div class="flex items-center justify-center h-full w-full">
          <p class="text-center">
            Can't change configs while the server is <b>offline</b>
          </p>
        </div>
      </CardBox>
      <div v-if="isServerOnline" class="slider">
        <div class="slide">
          <div lass="grid grid-cols-1 gap-6">
            <SectionTitleLine
              :icon="mdiCog"
              :title="state.pageTitles[state.currentIndex]"
              main
            >
            </SectionTitleLine>

            <CardBox class="mb-5">
              <BaseButtons type="justify-start">
                <BaseButton
                  color="info"
                  label="World"
                  icon-size="25"
                  small
                  @click="selectConfig(0)"
                />
                <BaseButton
                  color="info"
                  label="Web"
                  small
                  @click="selectConfig(1)"
                />
                <BaseButton
                  color="info"
                  label="Barracks"
                  small
                  @click="selectConfig(2)"
                />
                <BaseButton
                  color="info"
                  label="Database"
                  small
                  @click="selectConfig(3)"
                />
                <BaseButton
                  color="info"
                  label="Commands"
                  small
                  @click="selectConfig(4)"
                />
                <BaseButton
                  color="info"
                  label="Log"
                  small
                  @click="selectConfig(5)"
                />
                <BaseButton
                  color="info"
                  label="Localization"
                  small
                  @click="selectConfig(6)"
                />
              </BaseButtons>
            </CardBox>

            <CardBox>
              <div>
                <BaseButtons>
                  <div class="flex justify-start">
                    <BaseButton
                      color="info"
                      :icon="mdiChevronLeft"
                      icon-size="25"
                      small
                      @click="slidePrev"
                    />
                    <BaseButton
                      color="info"
                      :icon="mdiChevronRight"
                      small
                      @click="slideNext"
                    />
                  </div>
                  <BaseButton
                    big
                    class="element ml-auto"
                    color="info"
                    :icon="mdiContentSave"
                    icon-size="25"
                    small
                    @click="saveConfigs"
                  />
                </BaseButtons>
              </div>

              <BaseDivider />

              <div
                v-if="state.currentIndex === 0"
                v-for="(entry, key) in instance.props.configs.world"
                :key="key"
              >
                <FormField :label="key" :help="entry.commentary">
                  <FormControl
                    v-model="instance.props.configs.world[key]['value']"
                    :name="entry.value"
                    required
                  />
                </FormField>
                <BaseDivider />
              </div>

              <div
                v-if="state.currentIndex === 1"
                v-for="(entry, key) in instance.props.configs.web"
                :key="key"
              >
                <FormField :label="key" :help="entry.commentary">
                  <FormControl
                    v-model="instance.props.configs.web[key]['value']"
                    :name="entry.value"
                    required
                  />
                </FormField>
                <BaseDivider />
              </div>

              <div
                v-if="state.currentIndex === 2"
                v-for="(entry, key) in instance.props.configs.barracks"
                :key="key"
              >
                <FormField :label="key" :help="entry.commentary">
                  <FormControl
                    v-model="instance.props.configs.barracks[key]['value']"
                    :name="entry.value"
                    required
                  />
                </FormField>
                <BaseDivider />
              </div>

              <div
                v-if="state.currentIndex === 3"
                v-for="(entry, key) in instance.props.configs.database"
                :key="key"
              >
                <FormField :label="key" :help="entry.commentary">
                  <FormControl
                    v-model="instance.props.configs.database[key]['value']"
                    :name="entry.value"
                    required
                  />
                </FormField>
                <BaseDivider />
              </div>

              <div
                v-if="state.currentIndex === 4"
                v-for="(entry, key) in instance.props.configs.commands"
                :key="key"
              >
                <FormField :label="key" :help="entry.commentary">
                  <FormControl
                    v-model="instance.props.configs.commands[key]['value']"
                    :name="entry.value"
                    required
                  />
                </FormField>
                <BaseDivider />
              </div>

              <div
                v-if="state.currentIndex === 5"
                v-for="(entry, key) in instance.props.configs.log"
                :key="key"
              >
                <FormField :label="key" :help="entry.commentary">
                  <FormControl
                    v-model="instance.props.configs.log[key]['value']"
                    :name="entry.value"
                    required
                  />
                </FormField>
                <BaseDivider />
              </div>

              <div
                v-if="state.currentIndex === 6"
                v-for="(entry, key) in instance.props.configs.localization"
                :key="key"
              >
                <FormField :label="key" :help="entry.commentary">
                  <FormControl
                    v-model="instance.props.configs.localization[key]['value']"
                    :name="entry.value"
                    required
                  />
                </FormField>
                <BaseDivider />
              </div>

              <div>
                <BaseButtons>
                  <div class="flex justify-start">
                    <BaseButton
                      color="info"
                      :icon="mdiChevronLeft"
                      icon-size="25"
                      small
                      @click="slidePrev"
                    />
                    <BaseButton
                      color="info"
                      :icon="mdiChevronRight"
                      small
                      @click="slideNext"
                    />
                  </div>
                  <BaseButton
                    big
                    class="element ml-auto"
                    color="info"
                    :icon="mdiContentSave"
                    icon-size="25"
                    small
                    @click="saveConfigs"
                  />
                </BaseButtons>
              </div>
            </CardBox>
          </div>
        </div>
      </div>
    </SectionMain>
  </LayoutAuthenticated>
</template>
