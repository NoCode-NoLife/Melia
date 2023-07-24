<script setup>
import UserAvatar from '@/components/UserAvatar.vue'
import { mdiAccount } from '@mdi/js'
</script>

<template>
  <UserAvatar :icon="mdiAccount">
    <slot />
  </UserAvatar>
</template>
