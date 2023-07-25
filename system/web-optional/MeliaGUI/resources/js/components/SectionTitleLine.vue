<script setup>
import { useSlots, computed } from 'vue'
import BaseIcon from '@/components/BaseIcon.vue'
import IconRounded from '@/components/IconRounded.vue'
import BaseButton from '@/components/BaseButton.vue'
import { usePage } from '@inertiajs/vue3'

defineProps({
  icon: {
    type: String,
    default: null,
  },
  title: {
    type: String,
    required: true,
  },
  main: Boolean,
  onlyWhenServerOnline: Boolean,
  action: {
    type: Function,
  },
  actionIcon: {
    type: String,
  },
})

const isServerOnline = usePage().props.isServerOnline

const hasSlot = computed(() => useSlots().default)
</script>

<template>
  <section
    :class="{ 'pt-6': !main }"
    class="mb-6 flex items-center justify-between"
  >
    <div class="flex items-center justify-start">
      <IconRounded
        v-if="icon && main"
        :icon="icon"
        color="light"
        class="mr-3"
        bg
      />
      <BaseIcon v-else-if="icon" :path="icon" class="mr-2" size="20" />
      <h1 :class="main ? 'text-3xl' : 'text-2xl'" class="leading-tight">
        {{ title }}
      </h1>
    </div>
    <slot v-if="hasSlot" />
    <BaseButton
      v-if="actionIcon && action"
      :icon="actionIcon"
      iconSize="20"
      color="whiteDark"
      :disabled="onlyWhenServerOnline ? !isServerOnline : false"
      @click="action"
    />
  </section>
</template>
