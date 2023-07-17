<script setup>
import { computed, ref, onMounted, toRef, getCurrentInstance } from "vue";
import {
  mdiAccountMultiple,
  mdiAccountMultipleCheck,
  mdiChartTimelineVariant,
  mdiReload,
  mdiChartPie,
} from "@mdi/js";
import * as chartConfig from "@/components/Charts/chart.config.js";
import LineChart from "@/components/Charts/LineChart.vue";
import SectionMain from "@/components/SectionMain.vue";
import CardBoxWidget from "@/components/CardBoxWidget.vue";
import CardBox from "@/components/CardBox.vue";
import TableSampleClients from "@/components/TableSampleClients.vue";
import BaseButton from "@/components/BaseButton.vue";
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
    }
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

const clientBarItems = computed(() =>{});
const transactionBarItems = computed(() => {});
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
          trend="Overflow"
          trend-type="alert"
          color="text-red-500"
          :icon="mdiChartTimelineVariant"
          :number="256"
          suffix="%"
          label="Performance"
        />
      </div>

      <SectionTitleLineWithButton :icon="mdiChartPie" title="Trends overview">
        <BaseButton
          :icon="mdiReload"
          color="whiteDark"
          @click="fillChartData"
        />
      </SectionTitleLineWithButton>

      <CardBox class="mb-6">
        <div v-if="chartData">
          <line-chart :data="chartData" class="h-96" />
        </div>
      </CardBox>

      <SectionTitleLineWithButton :icon="mdiAccountMultiple" title="Last Accounts" />

      <CardBox has-table>
        <TableSampleClients :items="lastAccounts" />
      </CardBox>
    </SectionMain>
  </LayoutAuthenticated>
</template>
