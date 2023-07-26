<script setup>
import { mdiCheckCircleOutline } from '@mdi/js'
import BaseIcon from '@/components/BaseIcon.vue'
</script>

<template>
  <li class="space-y-2">
    <div class="flex items-center space-x-2">
      <CheckCircleIcon />
      <BaseIcon
        :path="mdiCheckCircleOutline"
        class="text-[#0c66ee]"
        :size="20"
      />
      <span>{{ title }}</span>
    </div>
    <slot></slot>
  </li>
</template>
<script>
export default {
  name: 'LandingListItem',
  props: {
    title: {
      type: String,
      default: '',
    },
  },
}
</script>
