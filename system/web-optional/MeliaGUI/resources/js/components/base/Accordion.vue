<script setup>
import { mdiChevronDown, mdiChevronUp } from '@mdi/js'
import BaseIcon from '@/components/BaseIcon.vue'
</script>

<template>
  <li class="relative border-b-2 border-gray-200">
    <button
      type="button"
      class="w-full py-4 text-left"
      @click="selected = !selected"
    >
      <div class="flex items-center justify-between">
        <span class="font-medium">{{ accordion.title }}</span>
        <BaseIcon v-if="selected" :path="mdiChevronUp" :size="20" />
        <BaseIcon v-else :path="mdiChevronDown" :size="20" />
      </div>
    </button>

    <transition name="slide">
      <div
        v-if="selected"
        class="relative overflow-hidden transition-all duration-700"
        style=""
      >
        <div class="py-2">
          <p class="text-sm text-gray-700 tracking-wide leading-relaxed">
            {{ accordion.description }}
          </p>
        </div>
      </div>
    </transition>
  </li>
</template>
<script>
export default {
  name: 'BaseAccordion',
  props: {
    accordion: {
      type: Object,
      required: true,
    },
  },
  data() {
    return {
      selected: false,
    }
  },
}
</script>
