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
  mdiBackupRestore,
  mdiMessage,
  mdiTagMultiple,
  mdiMailbox,
} from "@mdi/js";
import { useStore } from 'vuex';
import { Head } from '@inertiajs/vue3'
import * as chartConfig from "@/components/Charts/chart.config.js";
import SectionMain from "@/components/SectionMain.vue";
import CardBoxWidget from "@/components/CardBoxWidget.vue";
import CardBox from "@/components/CardBox.vue";
import TableAccounts from "@/components/TableAccounts.vue";
import TableProcesses from "@/components/TableProcesses.vue";
import LayoutAuthenticated from "@/layouts/LayoutAuthenticated.vue";
import CardBoxAction from "@/components/CardBoxAction.vue";
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
    totalCpuUsage: {
        type: Number,
        required: true
    },
})

const chartData = ref(null);

const fillChartData = () => {
  chartData.value = chartConfig.sampleChartData();
};

const kickAllPlayers = () => {};

const broadcastMessage = () => {};

const sendMail = () => {};

const backupDatabase = () => {};

const restoreBackup = () => {};

const inspectInventories = () => {};

const store = useStore();
const instance = getCurrentInstance();
const accountRef = toRef(instance.props, 'account');

const transactionBarItems = [
    { amount: 375.53, name: "Home Loan Account", date: "3 days ago", type: "deposit", business: "Turcotte" },
    { amount: 470.26, name: "Savings Account", date: "3 days ago", type: "payment", business: "Murazik - Graham" },
    { amount: 971.34, name: "Checking Account", date: "5 days ago", type: "invoice", business: "Fahey - Keebler" },
    { amount: 374.63, name: "Auto Loan Account", date: "7 days ago", type: "withdrawal", business: "Collier - Hintz" }
];

const clientBarItems = computed(() => instance.props.lastAccounts.slice(0, 4));

onMounted(() => {
  fillChartData();
  store.commit('setAccount', accountRef.value);
});
</script>

<template>
    <Head title="Dashboard" />
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
                    <CardBoxAction :icon="mdiLanDisconnect" :title="'Kick all'" :description="'Kick all players from the server.'" :action="kickAllPlayers" />
                    <CardBoxAction :icon="mdiMessage" :title="'Broadcast message'" :description="'Sends a message to all players.'" :action="broadcastMessage" />
                    <CardBoxAction :icon="mdiMailbox" :title="'Send mail'" :description="'Select items to send to players.'" :action="sendMail" />
                </div>
                <div class="flex flex-col justify-between">
                    <CardBoxAction :icon="mdiCloudUploadOutline" :title="'Backup database'" :description="'Make a new database backup.'" :action="backupDatabase" />
                    <CardBoxAction :icon="mdiBackupRestore" :title="'Restoure database backup'" :description="'Select a database backup to restore.'" :action="restoreBackup" />
                    <CardBoxAction :icon="mdiTagMultiple" :title="'Inspect inventories'" :description="'Select a database backup to restore.'" :action="inspectInventories" />
                </div>
        </div>

            <SectionTitleLineWithButton :icon="mdiCpu64Bit" title="Server's Processes" />

            <CardBox has-table>
                <TableProcesses :items="processes" />
            </CardBox>

            <SectionTitleLineWithButton :icon="mdiAccountMultiple" title="Last Accounts" />

            <CardBox has-table>
                <TableAccounts :items="lastAccounts" />
            </CardBox>

        </SectionMain>
    </LayoutAuthenticated>
</template>
