<script setup>
import { computed, ref } from "vue";
import { mdiCheckDecagram } from "@mdi/js";
import BaseLevel from "@/components/BaseLevel.vue";
import UserAvatarCurrentUser from "@/components/UserAvatarCurrentUser.vue";
import CardBox from "@/components/CardBox.vue";
import FormCheckRadio from "@/components/FormCheckRadio.vue";
import PillTag from "@/components/PillTag.vue";
import { useStore } from 'vuex';
import { Link, useForm, usePage } from '@inertiajs/vue3';


const store = useStore();

const userName = usePage().props.account.name;

const userSwitchVal = ref(false);

</script>

<template>
    <CardBox>
        <div class="flex justify-start">
            <BaseLevel type="justify-around lg:justify-center">
            <div class="space-y-3 text-center md:text-left lg:mx-12">
                <h1 class="text-2xl">
                Hello, <b>{{ userName }}</b>!
                </h1>
                <p>Last login <b>12 mins ago</b> from <b>127.0.0.1</b></p>
            </div>
            </BaseLevel>
        </div>
    </CardBox>
</template>
