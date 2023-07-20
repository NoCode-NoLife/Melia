<script setup>
import { ref, onMounted, toRef, getCurrentInstance, computed } from "vue";
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
  mdiCloudPlusOutline,
} from "@mdi/js";
import { useStore } from 'vuex';
import { Head, router } from '@inertiajs/vue3'
import * as chartConfig from "@/components/Charts/chart.config.js";
import SectionMain from "@/components/SectionMain.vue";
import CardBoxWidget from "@/components/CardBoxWidget.vue";
import CardBox from "@/components/CardBox.vue";
import TableAccounts from "@/components/TableAccounts.vue";
import TableProcesses from "@/components/TableProcesses.vue";
import TableBackups from "@/components/TableBackups.vue";
import LayoutAuthenticated from "@/layouts/LayoutAuthenticated.vue";
import CardBoxAction from "@/components/CardBoxAction.vue";
import OverlayLayer from "@/components/OverlayLayer.vue";
import SectionTitleLineWithButton from "@/components/SectionTitleLineWithButton.vue";

defineProps({
    account: {
        type: Object,
        required: true
    },
    onlineAccounts: {
        type: Number,
        required: true
    },
    totalAccounts: {
        type: Number,
        required: true
    },
    lastAccounts: {
        type: Array,
        required: true
    },
    processes: {
        type: Array,
        required: true
    },
    backups: {
        type: Array,
        required: true
    },
    totalCpuUsage: {
        type: Number,
        required: true
    },
    isServerOnline: {
        type: Boolean,
        required: true
    }
})

const chartData = ref(null);
const isLoading = ref(false);

const fillChartData = () => {
  chartData.value = chartConfig.sampleChartData();
};

const kickAllPlayers = () => {
    router.post(route('admin.kick.all.players'));
};

const kickPlayer = (playerAccountId) => {
    // router.post(route('kick.player', playerAccountId));
};

const broadcastMessage = () => {};

const sendMail = () => {};

const createNewBackup = () => {
    isLoading.value = true;
    router.post(route('admin.backup.create'));
}

const restoreBackup = () => {};

const inspectInventories = () => {};

const store = useStore();
const instance = getCurrentInstance();
const accountRef = toRef(instance.props, 'account');

onMounted(() => {
  fillChartData();
  store.commit('setAccount', accountRef.value);
});
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
            <svg aria-hidden="true" class="inline w-8 h-8 mr-2 text-gray-200 animate-spin dark:text-gray-600 fill-green-500" viewBox="0 0 100 101" fill="none" xmlns="http://www.w3.org/2000/svg">
                <path d="M100 50.5908C100 78.2051 77.6142 100.591 50 100.591C22.3858 100.591 0 78.2051 0 50.5908C0 22.9766 22.3858 0.59082 50 0.59082C77.6142 0.59082 100 22.9766 100 50.5908ZM9.08144 50.5908C9.08144 73.1895 27.4013 91.5094 50 91.5094C72.5987 91.5094 90.9186 73.1895 90.9186 50.5908C90.9186 27.9921 72.5987 9.67226 50 9.67226C27.4013 9.67226 9.08144 27.9921 9.08144 50.5908Z" fill="currentColor"/>
                <path d="M93.9676 39.0409C96.393 38.4038 97.8624 35.9116 97.0079 33.5539C95.2932 28.8227 92.871 24.3692 89.8167 20.348C85.8452 15.1192 80.8826 10.7238 75.2124 7.41289C69.5422 4.10194 63.2754 1.94025 56.7698 1.05124C51.7666 0.367541 46.6976 0.446843 41.7345 1.27873C39.2613 1.69328 37.813 4.19778 38.4501 6.62326C39.0873 9.04874 41.5694 10.4717 44.0505 10.1071C47.8511 9.54855 51.7191 9.52689 55.5402 10.0491C60.8642 10.7766 65.9928 12.5457 70.6331 15.2552C75.2735 17.9648 79.3347 21.5619 82.5849 25.841C84.9175 28.9121 86.7997 32.2913 88.1811 35.8758C89.083 38.2158 91.5421 39.6781 93.9676 39.0409Z" fill="currentFill"/>
            </svg>
            <span class="sr-only">Loading...</span>
        </div>
    </OverlayLayer>

    <LayoutAuthenticated>
        <SectionMain>
            <SectionTitleLineWithButton
                :icon="mdiChartTimelineVariant"
                title="Overview"
                main
            >
            </SectionTitleLineWithButton>

            <div class="grid grid-cols-1 gap-6 lg:grid-cols-3 mb-6">
                <CardBoxWidget
                    trend-type="up"
                    color="text-green-500"
                    :icon="mdiAccountMultipleCheck"
                    :number="onlineAccounts"
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
                    suffix="%"
                    label="Total CPU Usage"
                />
            </div>

            <SectionTitleLineWithButton :icon="mdiServer" title="Server's Management" />


            <div class="grid grid-cols-1 lg:grid-cols-2 gap-6 mb-6">
                <div class="flex flex-col justify-between">
                    <CardBoxAction :canInteract="isServerOnline" :icon="mdiLanDisconnect" :title="'Kick all'" :description="'Kick all players from the server.'" :action="kickAllPlayers" />
                    <CardBoxAction :canInteract="isServerOnline" :icon="mdiMessage" :title="'Broadcast message'" :description="'Sends a message to all players.'" :action="broadcastMessage" />
                    <CardBoxAction :canInteract="true" :icon="mdiMailbox" :title="'Send mail'" :description="'Select items to send to players.'" :action="sendMail" />
                </div>
                <div class="flex flex-col justify-between">
                    <CardBoxAction :canInteract="true" :icon="mdiCloudUploadOutline" :title="'Backup database'" :description="'Make a new database backup.'" :action="createNewBackup" />
                    <CardBoxAction :canInteract="true" :icon="mdiBackupRestore" :title="'Restoure database backup'" :description="'Select a database backup to restore.'" :action="restoreBackup" />
                    <CardBoxAction :canInteract="true" :icon="mdiTagMultiple" :title="'Inspect inventories'" :description="'Select a database backup to restore.'" :action="inspectInventories" />
                </div>
        </div>

            <SectionTitleLineWithButton :icon="mdiCpu64Bit" title="Server's Processes" />

            <CardBox has-table>
                <TableProcesses :items="processes" />
            </CardBox>

            <SectionTitleLineWithButton :icon="mdiBackupRestore" title="Backups" :action="createNewBackup" :actionIcon="mdiCloudPlusOutline" />

            <CardBox has-table>
                <TableBackups :items="backups" />
            </CardBox>

            <SectionTitleLineWithButton :icon="mdiAccountMultiple" title="Last Accounts" />

            <CardBox has-table>
                <TableAccounts :items="lastAccounts" />
            </CardBox>

        </SectionMain>
    </LayoutAuthenticated>
</template>
