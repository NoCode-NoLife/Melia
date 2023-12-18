<script setup>
import { onMounted, toRef, getCurrentInstance, computed } from 'vue'
import { mdiChartTimelineVariant } from '@mdi/js'
import { useStore } from 'vuex'
import { Head } from '@inertiajs/vue3'
import SectionMain from '@/components/SectionMain.vue'
import LayoutAuthenticated from '../Layouts/LayoutAuthenticated.vue'
import SectionTitleLine from '@/components/SectionTitleLine.vue'

defineProps({
  account: {
    type: Object,
    required: true,
  },
})

const store = useStore()
const instance = getCurrentInstance()
const accountRef = toRef(instance.props, 'account')

onMounted(() => {
  store.commit('setAccount', accountRef.value)
})
</script>

<template>
  <Head title="Dashboard" />
  <LayoutAuthenticated>
    <SectionMain>
      <SectionTitleLine :icon="mdiChartTimelineVariant" title="Overview" main>
      </SectionTitleLine>
    </SectionMain>
  </LayoutAuthenticated>
</template>
