<script setup>
import { mdiForwardburger, mdiBackburger, mdiMenu } from '@mdi/js'
import { ref } from 'vue'
import menuAside from '@/menuAside.js'
import menuNavBar from '@/menuNavBar.js'
import BaseIcon from '@/components/BaseIcon.vue'
import NavBar from '@/components/NavBar.vue'
import NavBarItemPlain from '@/components/NavBarItemPlain.vue'
import AsideMenu from '@/components/AsideMenu.vue'
import FooterBar from '@/components/FooterBar.vue'
import { useStore } from 'vuex'
import { darkModeKey, styleKey } from '@/config'
import { router } from '@inertiajs/vue3'

const layoutAsidePadding = 'xl:pl-60'

const isAsideMobileExpanded = ref(false)
const isAsideLgActive = ref(false)
const store = useStore()

/* App style */
store.commit('setStyle', localStorage[styleKey] ?? 'basic')

/* Dark mode */
if (
  (!localStorage[darkModeKey] &&
    window.matchMedia('(prefers-color-scheme: dark)').matches) ||
  localStorage[darkModeKey] === '1'
) {
  store.commit('setDarkMode', true)
}

const menuClick = (event, item) => {
  if (item.isToggleLightDark) {
    store.commit('setDarkMode', !store.state.darkMode)
  }

  if (item.isLogout) {
    router.post(route('logout'))
  }

  if (!item.isToggleLightDark && !item.isLogout && item.to != null) {
    router.get(item.to)
  }
}
</script>

<template>
  <div
    :class="{
      dark: store.state.darkMode,
      'overflow-hidden lg:overflow-visible': isAsideMobileExpanded,
    }"
  >
    <div
      :class="[layoutAsidePadding, { 'ml-60 lg:ml-0': isAsideMobileExpanded }]"
      class="pt-14 min-h-screen w-screen transition-position lg:w-auto bg-gray-50 dark:bg-slate-800 dark:text-slate-100"
    >
      <NavBar
        :menu="menuNavBar"
        :class="[
          layoutAsidePadding,
          { 'ml-60 lg:ml-0': isAsideMobileExpanded },
        ]"
        @menu-click="menuClick"
      >
        <NavBarItemPlain
          display="flex lg:hidden"
          @click.prevent="isAsideMobileExpanded = !isAsideMobileExpanded"
        >
          <BaseIcon
            :path="isAsideMobileExpanded ? mdiBackburger : mdiForwardburger"
            size="24"
          />
        </NavBarItemPlain>
        <NavBarItemPlain
          display="hidden lg:flex xl:hidden"
          @click.prevent="isAsideLgActive = true"
        >
          <BaseIcon :path="mdiMenu" size="24" />
        </NavBarItemPlain>
      </NavBar>
      <AsideMenu
        :is-aside-mobile-expanded="isAsideMobileExpanded"
        :is-aside-lg-active="isAsideLgActive"
        :menu="menuAside"
        @menu-click="menuClick"
        @aside-lg-close-click="isAsideLgActive = false"
      />
      <slot />
      <FooterBar> </FooterBar>
    </div>
  </div>
</template>
