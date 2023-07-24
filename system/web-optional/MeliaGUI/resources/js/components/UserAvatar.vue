<script setup>
import BaseIcon from '@/components/BaseIcon.vue'

defineProps({
  icon: {
    type: String,
    default: null,
  },
})
</script>

<template>
  <div>
    <BaseIcon
      :path="icon"
      class="rounded-full block h-auto w-full max-w-full bg-gray-100 dark:bg-slate-800"
      w="w-16"
      :size="25"
    />
    <slot />
  </div>
</template>
