<script setup>
import UserAvatar from "@/components/UserAvatar.vue";

</script>

<template>
  <UserAvatar :username="testuserName" :avatar="null">
    <slot />
  </UserAvatar>
</template>
