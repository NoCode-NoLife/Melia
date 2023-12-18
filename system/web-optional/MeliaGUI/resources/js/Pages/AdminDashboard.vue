<script setup>
import { ref, onMounted, toRef, getCurrentInstance } from 'vue'
import {
  mdiAccountMultiple,
  mdiAccountMultipleCheck,
  mdiChartTimelineVariant,
  mdiCpu64Bit,
  mdiServer,
  mdiLanDisconnect,
  mdiCloudUploadOutline,
  mdiMessage,
  mdiTagMultiple,
  mdiMailbox,
  mdiBackupRestore,
  mdiInformation,
  mdiCheckCircle,
  mdiAlert,
  mdiAlertCircle,
  mdiChartBox,
  mdiPlus,
} from '@mdi/js'
import { useStore } from 'vuex'
import { Head, router } from '@inertiajs/vue3'
import SectionMain from '@/components/SectionMain.vue'
import CardBoxWidget from '@/components/CardBoxWidget.vue'
import TableAccounts from '@/components/TableAccounts.vue'
import TableProcesses from '@/components/TableProcesses.vue'
import TableBackups from '@/components/TableBackups.vue'
import LayoutAuthenticated from '../Layouts/LayoutAuthenticated.vue'
import CardBoxAction from '@/components/CardBoxAction.vue'
import OverlayLayer from '@/components/OverlayLayer.vue'
import SectionTitleLine from '@/components/SectionTitleLine.vue'
import BaseDivider from '@/components/BaseDivider.vue'
import CardBox from '@/components/CardBox.vue'
import FormControl from '@/components/FormControl.vue'
import FormField from '@/components/FormField.vue'
import CardBoxModal from '@/components/CardBoxModal.vue'
import NotificationBar from '@/components/NotificationBar.vue'
import SilverChart from '@/components/Charts/SilverChart.vue'
import JobsChart from '@/components/Charts/JobsChart.vue'
import BaseIcon from '@/components/BaseIcon.vue'

const props = defineProps({
  account: {
    type: Object,
    required: true,
  },
  onlineAccounts: {
    type: Number,
    required: true,
  },
  totalAccounts: {
    type: Number,
    required: true,
  },
  lastAccounts: {
    type: Array,
    required: true,
  },
  processes: {
    type: Array,
    required: true,
  },
  backups: {
    type: Array,
    required: true,
  },
  totalCpuUsage: {
    type: Number,
    required: true,
  },
  isServerOnline: {
    type: Boolean,
    required: true,
  },
  status: {
    type: Object,
  },
  silverChartData: {
    type: Object,
    required: true,
  },
  jobClassChartData: {
    type: Object,
    required: true,
  },
})

const isLoading = ref(false)
const isBroadcastMessageModalActive = ref(false)
const broadcastMessageText = ref('')
const notificationIcon = ref('')

const isWarningModalActive = ref(false)
const warningMessage = ref('')
const warningCall = ref(null)

const kickAllPlayers = () => {
  isWarningModalActive.value = false
  router.post(route('admin.kick.all.players'))
}

const kickAllPlayersWarning = () => {
  isWarningModalActive.value = true
  warningMessage.value =
    'Are you sure that you want to kick all players from the server?'
  warningCall.value = () => {
    kickAllPlayers()
  }
}

const warningRestoreBackup = (backup) => {
  isWarningModalActive.value = true
  warningMessage.value = 'Do you really want to restore the backup?'
  warningCall.value = () => {
    restoreBackup(backup)
  }
}

const warningCloseProcess = (process) => {
  isWarningModalActive.value = true
  warningMessage.value =
    'Do you really want to close the process ' + process.ProcessName + ' ?'
  warningCall.value = () => {
    closeProcess(process)
  }
}

const warningCreateNewZone = () => {
  isWarningModalActive.value = true
  warningMessage.value =
    'Do you really want to create a new zone server for all maps?'
  warningCall.value = () => {
    createNewZoneServer()
  }
}

const closeProcess = (process) => {
  isLoading.value = true
  isWarningModalActive.value = false
  router.post(
    route('admin.close.zone.server.process'),
    {
      processId: process.ProcessId,
    },
    {
      preserveState: true,
      preserveScroll: false,
      onFinish: (visit) => {
        isLoading.value = false
      },
    },
  )
}

const restoreBackup = (backup) => {
  isLoading.value = true
  isWarningModalActive.value = false
  router.post(
    route('admin.backup.restore'),
    {
      backupDate: backup.date,
    },
    {
      preserveState: true,
      preserveScroll: false,
      onFinish: (visit) => {
        isLoading.value = false
      },
    },
  )
}

const createNewZoneServer = () => {
  isLoading.value = true
  isWarningModalActive.value = false
  router.post(route('admin.create.zone.server'), null, {
    preserveState: true,
    preserveScroll: false,
    onFinish: (page) => {
      isLoading.value = false
    },
    onSuccess: (page) => {
      isLoading.value = false
    },
  })
}

const kickPlayer = (playerAccountId) => {
  // router.post(route('kick.player', playerAccountId));
}

const broadcastMessage = () => {
  isLoading.value = true
  router.post(
    route('admin.message.broadcast'),
    { message: broadcastMessageText.value },
    {
      preserveState: false,
      preserveScroll: true,
      onSuccess: (page) => {
        isLoading.value = false
      },
      onFinish: (page) => {
        isLoading.value = false
      },
    },
  )
}

const sendMail = () => {}

const setLoading = (value) => {
  isLoading.value = value
}

const createNewBackup = () => {
  isLoading.value = true
  isBroadcastMessageModalActive.value = false

  router.post(route('admin.backup.create'), null, {
    preserveState: false,
    preserveScroll: true,
    onSuccess: (page) => {
      isLoading.value = false
    },
    onFinish: (page) => {
      isLoading.value = false
    },
  })
}

const inspectInventories = () => {
  router.get(route('admin.inventory.manager'))
}

const store = useStore()
const instance = getCurrentInstance()
const accountRef = toRef(instance.props, 'account')
const isServerOnlineRef = toRef(instance.props, 'isServerOnline')

onMounted(() => {
  store.commit('setAccount', accountRef.value)
  store.commit('setIsServerOnline', isServerOnlineRef.value)
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
  <Head title="Dashboard" />

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
    <CardBoxModal
      v-model="isBroadcastMessageModalActive"
      title="Enter the message that you want to broadcast:"
      button="info"
      :confirm="broadcastMessage"
      has-cancel
    >
      <BaseDivider />
      <FormField label="message">
        <FormControl v-model="broadcastMessageText" name="message" required />
      </FormField>
    </CardBoxModal>

    <CardBoxModal
      v-model="isWarningModalActive"
      title="Warning!"
      button="info"
      :confirm="warningCall"
      has-cancel
    >
      <BaseDivider />
      <div>
        <p>{{ warningMessage }}</p>
      </div>
    </CardBoxModal>

    <SectionMain>
      <NotificationBar
        v-if="props.status"
        :color="props.status.type"
        :icon="notificationIcon"
        :outline="false"
      >
        {{ props.status.message }}
      </NotificationBar>

      <SectionTitleLine :icon="mdiChartTimelineVariant" title="Overview" main>
      </SectionTitleLine>

      <div class="grid grid-cols-1 gap-6 lg:grid-cols-3 mb-6">
        <CardBoxWidget
          trend-type="up"
          color="text-green-500"
          :icon="mdiAccountMultipleCheck"
          :number="onlineAccounts"
          :showOnOffline="false"
          label="Online"
        />
        <CardBoxWidget
          trend-type="up"
          color="text-gray-500"
          :icon="mdiAccountMultiple"
          :number="totalAccounts"
          label="Accounts"
        />
        <CardBoxWidget
          color="text-red-500"
          :icon="mdiChartTimelineVariant"
          :number="totalCpuUsage"
          :showOnOffline="false"
          suffix="%"
          label="Total CPU Usage"
        />
      </div>

      <div
        class="flex flex-col md:flex-row gap-4"
        v-if="
          silverChartData != undefined &&
          silverChartData.length > 0 &&
          jobClassChartData != undefined &&
          jobClassChartData.length > 0
        "
      >
        <div class="flex-1 mb-6">
          <CardBox>
            <SilverChart :data="silverChartData" class="mb-2" />
            <BaseDivider chart />
            <div class="flex justify-between">
              <BaseIcon
                class="text-black dark:text-gray-500"
                :path="mdiChartBox"
                size="24"
              />
              <p class="text-center text-black dark:text-gray-500">
                Top 10 most rich teams
              </p>
            </div>
          </CardBox>
        </div>
        <div class="flex-1">
          <CardBox>
            <JobsChart :data="jobClassChartData" class="mb-2" />
            <BaseDivider chart />
            <div class="flex justify-between">
              <BaseIcon
                class="text-black dark:text-gray-500"
                :path="mdiChartBox"
                size="24"
              />
              <p class="text-center text-black dark:text-gray-500">
                All chosen jobs
              </p>
            </div>
          </CardBox>
        </div>
      </div>

      <SectionTitleLine
        class="mt-2 pt-2 pb-2"
        :icon="mdiServer"
        title="Server's Management"
      />

      <div class="grid grid-cols-1 lg:grid-cols-2 gap-6 mb-6">
        <div class="flex flex-col justify-between">
          <CardBoxAction
            :canInteract="isServerOnline"
            :icon="mdiLanDisconnect"
            :title="'Kick all'"
            :description="'Kick all players from the server.'"
            :action="kickAllPlayersWarning"
          />
          <CardBoxAction
            :canInteract="isServerOnline"
            :icon="mdiMessage"
            :title="'Broadcast message'"
            :description="'Sends a message to all players.'"
            :action="() => (isBroadcastMessageModalActive = true)"
          />
          <CardBoxAction
            :canInteract="true"
            :icon="mdiMailbox"
            :title="'Send mail'"
            :description="'Select items to send to players.'"
            :action="sendMail"
          />
        </div>
        <div class="flex flex-col justify-between">
          <CardBoxAction
            :canInteract="true"
            :icon="mdiCloudUploadOutline"
            :title="'Backup database'"
            :description="'Make a new database backup.'"
            :action="createNewBackup"
          />
          <CardBoxAction
            :canInteract="true"
            :icon="mdiCpu64Bit"
            :title="'New zone server'"
            :description="'Creates a new instance of zone server'"
            :action="warningCreateNewZone"
          />
          <CardBoxAction
            :canInteract="true"
            :icon="mdiTagMultiple"
            :title="'Inspect inventories'"
            :description="'Inspect inventories of players'"
            :action="inspectInventories"
          />
        </div>
      </div>

      <SectionTitleLine
        class="mt-0 pt-0 pb-2"
        :icon="mdiCpu64Bit"
        title="Server's Processes"
        :action="warningCreateNewZone"
        :actionIcon="mdiPlus"
        onlyWhenServerOnline
      />

      <CardBox has-table>
        <TableProcesses
          :items="processes"
          :warningCloseProcess="warningCloseProcess"
        />
      </CardBox>

      <SectionTitleLine
        :icon="mdiBackupRestore"
        title="Backups"
        :actionIcon="mdiPlus"
        :action="createNewBackup"
      />

      <CardBox has-table>
        <TableBackups
          :warningRestoreBackup="warningRestoreBackup"
          :items="backups"
          :setLoading="setLoading"
        />
      </CardBox>

      <SectionTitleLine :icon="mdiAccountMultiple" title="Last Accounts" />

      <CardBox has-table>
        <TableAccounts :items="lastAccounts" />
      </CardBox>
    </SectionMain>
  </LayoutAuthenticated>
</template>
