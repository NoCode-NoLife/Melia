<script setup>
import AuthenticatedLayout from '@/Layouts/AuthenticatedLayout.vue';
import { Head } from '@inertiajs/vue3';
import { HomeIcon, UserIcon, CogIcon } from '@heroicons/vue/24/solid'

defineProps({
    account: {
        type: Object,
        required: true,
    }
});
</script>

<template>
    <Head title="Dashboard" />

    <AuthenticatedLayout :account="account">
        <template #header>
            <h2 class="font-semibold text-xl text-gray-800 leading-tight">Dashboard</h2>
        </template>

    </AuthenticatedLayout>
</template>

