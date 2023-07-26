<script setup>
import { mdiSegment, mdiClose, mdiChevronUp, mdiChevronDown } from '@mdi/js'
import BaseIcon from '@/components/BaseIcon.vue'
import NavLink from '@/components/HomeNavLink.vue'
</script>

<template>
  <nav id="navbar" class="relative z-10 w-full text-neutral-800">
    <div
      class="flex flex-col max-w-screen-xl px-8 mx-auto lg:items-center lg:justify-between lg:flex-row py-4"
    >
      <div
        class="flex flex-col lg:flex-row items-center space-x-4 xl:space-x-8"
      >
        <div class="w-full flex flex-row items-center justify-between py-6">
          <div>
            <img
              src="/assets/img/logo_black.png"
              class="w-24 xl:w-28"
              alt="Nefa Logo"
            />
          </div>
          <button
            class="rounded-lg lg:hidden focus:outline-none focus:shadow-outline"
            @click="open = !open"
          >
            <BaseIcon v-if="!open" :path="mdiSegment" :size="24" />
            <BaseIcon v-else :path="mdiClose" :size="24" />
          </button>
        </div>
        <ul
          :class="[open ? 'flex' : 'hidden lg:flex']"
          class="w-full h-auto flex flex-col flex-grow lg:items-center pb-4 lg:pb-0 lg:justify-end lg:flex-row origin-top duration-300 xl:space-x-2 space-y-3 lg:space-y-0"
        >
          <NavLink name="Home" :url="route('login')" />
          <NavLink
            name="About"
            newPage
            url="https://github.com/NoCode-NoLife/melia/wiki/FAQ"
          />
          <NavLink
            name="Github"
            newPage
            url="https://github.com/NoCode-NoLife/melia"
          />
          <NavLink name="Contact" url="#" />
          <NavLink name="PrivacyPolicy" url="#" />
        </ul>
      </div>
      <div :class="[open ? 'flex' : 'hidden lg:flex']" class="space-x-3">
        <button
          class="px-8 xl:px-10 py-3 mt-2 rounded-full bg-inherit text-gradient border border-[#0c66ee]"
        >
          Login
        </button>
        <button
          class="px-8 xl:px-10 py-3 mt-2 rounded-full bg-gradient-to-r from-[#468ef9] to-[#0c66ee] text-white"
        >
          Register
        </button>
      </div>
    </div>
  </nav>
</template>
<script>
export default {
  name: 'BaseNavbar',
  data() {
    return {
      open: false,
      dropdownNavbar: false,
    }
  },
  methods: {
    dropdownToggler() {
      this.dropdownNavbar = !this.dropdownNavbar
    },
  },
}
</script>
