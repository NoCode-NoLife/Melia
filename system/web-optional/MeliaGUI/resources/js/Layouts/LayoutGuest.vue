<script setup>
import { useStore } from 'vuex'
import { darkModeKey } from '@/config'

const store = useStore()

if (
  (!localStorage[darkModeKey] &&
    window.matchMedia('(prefers-color-scheme: dark)').matches) ||
  localStorage[darkModeKey] === '1'
) {
  store.commit('setDarkMode', true)
}
</script>

<template>
  <div :class="{ dark: store.state.darkMode }">
    <div class="bg-gray-50 dark:bg-slate-800 dark:text-slate-100">
      <slot />
    </div>
  </div>
</template>
