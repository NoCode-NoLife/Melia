<script setup>
import { computed, ref, getCurrentInstance } from "vue";
import { mdiChip  } from "@mdi/js";
import TableCheckboxCell from "@/components/TableCheckboxCell.vue";
import BaseLevel from "@/components/BaseLevel.vue";
import BaseButtons from "@/components/BaseButtons.vue";
import BaseButton from "@/components/BaseButton.vue";
import UserAvatar from "@/components/UserAvatar.vue";

defineProps({
  checkable: Boolean,
  items: {
    type: Array,
    required: true
  }
});

const perPage = ref(5);

const currentPage = ref(0);

const checkedRows = ref([]);

const instance = getCurrentInstance();

const itemsPaginated = computed(() =>
    instance.props.items.slice(
        perPage.value * currentPage.value,
        perPage.value * (currentPage.value + 1)
    )
);

const numPages = computed(() => Math.ceil(instance.props.items.length / perPage.value));

const currentPageHuman = computed(() => currentPage.value + 1);

const pagesList = computed(() => {
  const pagesList = [];

  for (let i = 0; i < numPages.value; i++) {
    pagesList.push(i);
  }

  return pagesList;
});

const remove = (arr, cb) => {
  const newArr = [];

  arr.forEach((item) => {
    if (!cb(item)) {
      newArr.push(item);
    }
  });

  return newArr;
};

const checked = (isChecked, userAccount) => {
  if (isChecked) {
    checkedRows.value.push(userAccount);
  } else {
    checkedRows.value = remove(
      checkedRows.value,
      (row) => row.id === userAccount.id
    );
  }
};
</script>

<template>
  <div v-if="checkedRows.length" class="p-3 bg-gray-100/50 dark:bg-slate-800">
    <span
      v-for="checkedRow in checkedRows"
      :key="checkedRow.id"
      class="inline-block px-2 py-1 rounded-sm mr-2 text-sm bg-gray-100 dark:bg-slate-700"
    >
      {{ checkedRow.name }}
    </span>
  </div>

  <table>
    <thead>
      <tr>
        <th v-if="checkable" />
        <th />
        <th>Process</th>
        <th>CpuUsage</th>
        <th>RamUsage</th>
        <th>ServerIP</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="process in itemsPaginated" :key="process.ProcessId">
        <TableCheckboxCell
          v-if="checkable"
          @checked="checked($event, process)"
        />
        <td class="border-b-0 lg:w-6 before:hidden">
          <UserAvatar
            :icon="mdiChip"
            class="w-24 h-24 mx-auto lg:w-6 lg:h-6"
          />
        </td>
        <td data-label="Name">
            {{ console.log(process) }}
          {{ process.ProcessName }} - ID: ({{ process.ProcessId }})
        </td>
        <td data-label="TeamName">
          {{ process.CpuUsage }} %
        </td>
        <td data-label="Medals">
          {{ process.RamUsage }} %
        </td>
        <td data-label="Medals">
          {{ process.ServerIp }}
        </td>
      </tr>
    </tbody>
  </table>
  <div v-show="numPages > 1" class="p-3 lg:px-6 border-t border-gray-100 dark:border-slate-800">
    <BaseLevel>
        <BaseButtons>
            <BaseButton
                v-for="page in pagesList"
                :key="page"
                :active="page === currentPage"
                :label="page + 1"
                :color="page === currentPage ? 'lightDark' : 'whiteDark'"
                small
                @click="currentPage = page"
            />
            <button
                class="inline-flex justify-center items-center whitespace-nowrap focus:outline-none transition-colors focus:ring duration-150 border cursor-pointer rounded border-white dark:border-slate-900 ring-gray-200 dark:ring-gray-500 bg-white text-black dark:bg-slate-900 dark:text-white hover:bg-gray-100 hover:dark:bg-slate-800 text-sm p-1 mr-3 last:mr-0 mb-3"
            >
                <span class="px-2 m-0 p-0 mr-0 mb-0">...</span>
            </button>
        </BaseButtons>
      <small v-show="numPages > 1">Page {{ currentPageHuman }} of {{ numPages }}</small>
    </BaseLevel>
  </div>
</template>
