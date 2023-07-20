<script setup>
import { mdiBallotOutline, mdiAccount, mdiMail, mdiFormTextboxPassword, mdiLock } from "@mdi/js";
import SectionFullScreen from "@/components/SectionFullScreen.vue";
import CardBox from "@/components/CardBox.vue";
import FormField from "@/components/FormField.vue";
import FormControl from "@/components/FormControl.vue";
import BaseButton from "@/components/BaseButton.vue";
import BaseButtons from "@/components/BaseButtons.vue";
import LayoutGuest from "@/layouts/LayoutGuest.vue";
import SectionTitleLineWithButton from "@/components/SectionTitleLineWithButton.vue";
import InputError from '@/Components/InputError.vue';
import { Head, useForm } from '@inertiajs/vue3';

const form = useForm({
    login: '',
    email: '',
    password: '',
    password_confirmation: '',
});

const submit = () => {
    form.post(route('register'), {
        onFinish: () => form.reset('password', 'password_confirmation'),
    });
};
</script>

<template>
    <Head title="Register" />
    <LayoutGuest>
        <SectionFullScreen v-slot="{ cardClass }" bg="purplePink">

            <CardBox isForm @submit.prevent="submit">
                <SectionTitleLineWithButton
                    :icon="mdiBallotOutline"
                    title="Register"
                    main
                >
                </SectionTitleLineWithButton>
                <InputError class="mt-2 mb-2" :message="form.errors.login" />
                <InputError class="mt-2 mb-2" :message="form.errors.email" />

                <FormField label="Credentials">
                <FormControl v-model="form.login" placeholder="Login" :icon="mdiAccount" />
                <FormControl v-model="form.email" placeholder="Email" type="email" :icon="mdiMail" />
                </FormField>

                <InputError :message="form.errors.password" class="mt-2 mb-2" />

                <FormField class="max-width-full" label="Password" help="Required. Password">
                    <FormControl
                        class="max-width-full"
                        v-model="form.password"
                        :icon="mdiLock"
                        name="password"
                        type="password"
                        autocomplete="new_password"
                        required
                    />
                </FormField>

                <InputError :message="form.errors.password_confirmation" class="mt-2 mb-2" />


                <FormField label="Password Confirmation" is-form help="Required. Password Confirmation.">
                    <FormControl
                        v-model="form.password_confirmation"
                        :icon="mdiFormTextboxPassword"
                        name="password_confirmation"
                        type="password"
                        autocomplete="password_confirmation"
                        required
                    />
                </FormField>

                <template #footer>
                <BaseButtons>
                    <BaseButton type="submit" color="info" label="Submit" :class="{ 'opacity-25': form.processing }" :disabled="form.processing"/>
                    <BaseButton type="reset" color="info" outline label="Reset" :class="{ 'opacity-25': form.processing }" :disabled="form.processing"/>
                </BaseButtons>
                </template>
            </CardBox>
        </SectionFullScreen>
    </LayoutGuest>
</template>
