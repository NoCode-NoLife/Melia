<script setup>
import { onMounted, toRef, getCurrentInstance, computed } from "vue";
import {
  mdiCogs,
  mdiCog,
} from "@mdi/js";
import { useStore } from 'vuex';
import { Head, useForm } from '@inertiajs/vue3'
import SectionMain from "@/components/SectionMain.vue";
import LayoutAuthenticated from "@/layouts/LayoutAuthenticated.vue";
import SectionTitleLineWithButton from "@/components/SectionTitleLineWithButton.vue";
import FormField from "@/components/FormField.vue";
import FormControl from "@/components/FormControl.vue";
import BaseButton from "@/components/BaseButton.vue";
import UserCard from "@/components/UserCard.vue";
import InputError from '@/Components/InputError.vue';
import BaseDivider from "@/components/BaseDivider.vue";
import CardBox from "@/components/CardBox.vue";

defineProps({
    account: {
        type: Object,
        required: true
    },
    backupSchedule: {
        type: String,
        required: true
    },
    enableTrading: {
        type: String,
        required: true
    },
})

const store = useStore();
const instance = getCurrentInstance();
const accountRef = toRef(instance.props, 'account');

onMounted(() => {
  store.commit('setAccount', accountRef.value);
});

const scheduleOptions = [
    { id: 1, label: "Disabled" },
    { id: 2, label: "Daily" },
    { id: 3, label: "Weekly" },
    { id: 4, label: "Monthly" },
];

const enableOrDisableOptions = [
    { id: 1, label: "Disabled" },
    { id: 2, label: "Enabled" },
];

const form = useForm({
    backupSchedule: scheduleOptions[0],
    enableTrading: enableOrDisableOptions[0],
});
</script>

<template>
    <Head title="Server Settings" />
    <LayoutAuthenticated>
        <SectionMain>
        <SectionTitleLineWithButton :icon="mdiCogs" title="Server Settings" main>
        </SectionTitleLineWithButton>

        <UserCard class="mb-6" />
            <div class="grid grid-cols-1 lg:grid-cols-2 gap-6">
                <CardBox is-form @submit.prevent="form.patch(route('profile.update'))">
                    <InputError :message="form.errors.backupSchedule" class="mt-2" />

                    <FormField label="Backup Schedule">
                        <FormControl v-model="form.backupSchedule" :options="scheduleOptions" />
                    </FormField>

                    <BaseDivider />

                    <FormField label="Backup Schedule">
                        <FormControl v-model="form.enableTrading" :options="enableOrDisableOptions" />
                    </FormField>

                    <BaseDivider />

                    <FormField label="Team Name" help="Your Team Name.">
                        <FormControl
                            v-model="form.enableTrading"
                            :icon="mdiCog"
                            name="backupSchedule"
                            required
                            autocomplete="backupSchedule"
                        />
                    </FormField>

                    <Transition
                        enter-active-class="transition ease-in-out"
                        enter-from-class="opacity-0"
                        leave-active-class="transition ease-in-out"
                        leave-to-class="opacity-0"
                    >
                        <p v-if="form.recentlySuccessful" class="text-sm text-gray-600">Settings Updated.</p>
                    </Transition>

                    <template #footer>
                        <BaseButton color="info" type="submit" label="Submit" />
                    </template>
                </CardBox>

                <CardBox is-form @submit.prevent="updatePassword">

                    <InputError :message="form.errors.backupSchedule" class="mt-2" />

                    <FormField label="Team Name" help="Your Team Name.">
                        <FormControl
                            v-model="form.enableTrading"
                            :icon="mdiCog"
                            name="backupSchedule"
                            required
                            autocomplete="backupSchedule"
                        />
                    </FormField>

                    <BaseDivider />

                    <FormField label="Team Name" help="Your Team Name.">
                        <FormControl
                            v-model="form.enableTrading"
                            :icon="mdiCog"
                            name="backupSchedule"
                            required
                            autocomplete="backupSchedule"
                        />
                    </FormField>

                    <FormField label="Team Name" help="Your Team Name.">
                        <FormControl
                            v-model="form.enableTrading"
                            :icon="mdiCog"
                            name="backupSchedule"
                            required
                            autocomplete="backupSchedule"
                        />
                    </FormField>

                    <Transition
                        enter-active-class="transition ease-in-out"
                        enter-from-class="opacity-0"
                        leave-active-class="transition ease-in-out"
                        leave-to-class="opacity-0"
                    >
                        <p v-if="form.recentlySuccessful" class="text-sm text-gray-600">Settings Updated.</p>
                    </Transition>

                    <template #footer>
                        <BaseButton color="info" type="submit" label="Submit" />
                    </template>
                </CardBox>
            </div>
        </SectionMain>
    </LayoutAuthenticated>
</template>
