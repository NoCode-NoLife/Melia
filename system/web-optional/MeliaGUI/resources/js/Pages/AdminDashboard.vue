<script setup>
import { computed, ref, onMounted, toRef, getCurrentInstance } from "vue";
import {
  mdiAccountMultiple,
  mdiAccountMultipleCheck,
  mdiChartTimelineVariant,
} from "@mdi/js";
import * as chartConfig from "@/components/Charts/chart.config.js";
import SectionMain from "@/components/SectionMain.vue";
import CardBoxWidget from "@/components/CardBoxWidget.vue";
import CardBox from "@/components/CardBox.vue";
import TableAccounts from "@/components/TableAccounts.vue";
import TableProcesses from "@/components/TableProcesses.vue";
import LayoutAuthenticated from "@/layouts/LayoutAuthenticated.vue";
import SectionTitleLineWithButton from "@/components/SectionTitleLineWithButton.vue";
import { useStore } from 'vuex';

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

const store = useStore();
const instance = getCurrentInstance();
const accountRef = toRef(instance.props, 'account');

onMounted(() => {
  fillChartData();
  store.commit('setAccount', accountRef.value);
});
</script>

<template>
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
          trend="12%"
          trend-type="up"
          color="text-green-500"
          :icon="mdiAccountMultipleCheck"
          :number="onlineAccounts"
          label="Online"
        />
        <CardBoxWidget
          trend="12%"
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

      <SectionTitleLineWithButton :icon="mdiAccountMultiple" title="Server's Processes" />

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
