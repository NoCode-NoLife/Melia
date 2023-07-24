<script setup>
import { ref, computed } from 'vue'
import { mdiMinus, mdiPlus } from '@mdi/js'
import { getButtonColor } from '@/colors.js'
import BaseIcon from '@/components/BaseIcon.vue'
import AsideMenuList from '@/components/AsideMenuList.vue'
import { usePage } from '@inertiajs/vue3'
import { Link } from '@inertiajs/vue3'
import { useStore } from 'vuex'

const props = defineProps({
  item: {
    type: Object,
    required: true,
  },
  isDropdownList: Boolean,
})

const authority = usePage().props.account
  ? usePage().props.account.authority
  : 0

const emit = defineEmits(['menu-click'])

const hasColor = computed(() => props.item && props.item.color)

const store = useStore()

const asideMenuItemActiveStyle = computed(() =>
  hasColor.value ? '' : store.state.asideMenuItemActiveStyle,
)

const isDropdownActive = ref(false)

const componentClass = computed(() => [
  props.isDropdownList ? 'py-3 px-6 text-sm' : 'py-3',
  hasColor.value
    ? getButtonColor(props.item.color, false, true)
    : `${store.state.asideMenuItemStyle} dark:text-slate-300 dark:hover:text-white`,
])

const hasDropdown = computed(() => !!props.item.menu)

const menuClick = (event) => {
  emit('menu-click', event, props.item)

  if (hasDropdown.value) {
    isDropdownActive.value = !isDropdownActive.value
  }
}
</script>

<template>
  <li v-show="props.item.admin ? authority >= 99 : true">
    <component
      :is="item.to ? Link : 'a'"
      v-slot="vSlot"
      :to="item.to ?? null"
      :href="item.href ?? null"
      :target="item.target ?? null"
      class="flex cursor-pointer"
      :class="componentClass"
      @click="menuClick"
    >
      <BaseIcon
        v-if="item.icon"
        :path="item.icon"
        class="flex-none text-white dark:text-white"
        :class="[vSlot && vSlot.isExactActive ? asideMenuItemActiveStyle : '']"
        w="w-16"
        :size="18"
      />
      <span
        class="grow text-ellipsis line-clamp-1 text-white"
        :class="[
          { 'pr-12': !hasDropdown },
          vSlot && vSlot.isExactActive ? asideMenuItemActiveStyle : '',
        ]"
        >{{ item.label }}</span
      >
      <BaseIcon
        v-if="hasDropdown"
        :path="isDropdownActive ? mdiMinus : mdiPlus"
        class="flex-none text-white dark:text-white"
        :class="[vSlot && vSlot.isExactActive ? asideMenuItemActiveStyle : '']"
        w="w-12"
      />
    </component>
    <AsideMenuList
      v-if="hasDropdown"
      :menu="item.menu"
      :class="[
        store.state.asideMenuDropdownStyle,
        isDropdownActive ? 'block dark:bg-slate-800/50' : 'hidden',
      ]"
      is-dropdown-list
    />
  </li>
</template>
