<script setup>
import CardBox from "@/components/CardBox.vue";
import BaseLevel from "@/components/BaseLevel.vue";
import IconRounded from "@/components/IconRounded.vue";
import BaseButton from "@/components/BaseButton.vue";
import {
  mdiPlayBoxOutline,
} from "@mdi/js";
const props = defineProps({
  action: {
    type: Function,
    required: true,
  },
  icon: {
    type: String,
    required: true,
  },
  title: {
    type: String,
    required: true,
  },
  description: {
    type: String,
    required: true,
  },
});
</script>

<template>
    <CardBox class="mb-6 last:mb-0" is-hoverable>
        <BaseLevel>
            <BaseLevel type="justify-start">
                <IconRounded :icon="icon" :color="'info'" class="md:mr-6" />
                <div class="text-center space-y-1 md:text-left md:mr-6">
                <h4 class="text-xl">{{ title }}</h4>
                <p class="text-gray-500 dark:text-slate-400">
                    {{ description }}
                </p>
                </div>
            </BaseLevel>
            <div class="text-center md:text-right space-y-2">
                <div>
                    <BaseButton
                        iconSize="25"
                        :icon="mdiPlayBoxOutline"
                        color="whiteDark"
                        rounded-full
                        big
                        @click.prevent="action"
                    />
                </div>
            </div>
        </BaseLevel>
    </CardBox>
</template>
