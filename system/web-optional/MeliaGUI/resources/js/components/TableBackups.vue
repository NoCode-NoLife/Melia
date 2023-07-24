<script setup>
import { computed, ref, getCurrentInstance } from 'vue'
import { mdiDelete, mdiRestoreAlert, mdiDatabase } from '@mdi/js'
import { router } from '@inertiajs/vue3'
import TableCheckboxCell from '@/components/TableCheckboxCell.vue'
import BaseLevel from '@/components/BaseLevel.vue'
import BaseButtons from '@/components/BaseButtons.vue'
import BaseButton from '@/components/BaseButton.vue'
import UserAvatar from '@/components/UserAvatar.vue'

defineProps({
  checkable: Boolean,
  items: {
    type: Array,
    required: true,
  },
  setLoading: {
    type: Function,
    required: true,
  },
  warningRestoreBackup: {
    type: Function,
    required: true,
  },
})

const perPage = ref(5)

const currentPage = ref(0)

const checkedRows = ref([])

const instance = getCurrentInstance()

const itemsPaginated = computed(() =>
  instance.props.items.slice(
    perPage.value * currentPage.value,
    perPage.value * (currentPage.value + 1),
  ),
)

const numPages = computed(() =>
  Math.ceil(instance.props.items.length / perPage.value),
)

const currentPageHuman = computed(() => currentPage.value + 1)

const pagesList = computed(() => {
  const pagesList = []

  for (let i = 0; i < numPages.value; i++) {
    pagesList.push(i)
  }

  return pagesList
})

const remove = (arr, cb) => {
  const newArr = []

  arr.forEach((item) => {
    if (!cb(item)) {
      newArr.push(item)
    }
  })

  return newArr
}

const checked = (isChecked, userAccount) => {
  if (isChecked) {
    checkedRows.value.push(userAccount)
  } else {
    checkedRows.value = remove(
      checkedRows.value,
      (row) => row.id === userAccount.id,
    )
  }
}

const deleteBackup = (backup) => {
  instance.props.setLoading(true)
  router.post(
    route('admin.backup.delete'),
    {
      backupDate: backup.date,
    },
    {
      preserveState: false,
      preserveScroll: true,
      onFinish: (visit) => {
        instance.props.setLoading(false)
      },
    },
  )
}
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

  <div v-show="itemsPaginated.length <= 0">
    <div
      class="text-center w-full py-12 bg-gray-100 dark:bg-gray-900 rounded-2xl"
    >
      <p class="text-gray-500 dark:text-slate-400">There is no backups yet.</p>
    </div>
  </div>

  <table v-show="itemsPaginated.length > 0">
    <thead>
      <tr>
        <th v-if="checkable" />
        <th />
        <th>Date</th>
        <th>Size</th>
        <th>path</th>
        <th />
      </tr>
    </thead>
    <tbody>
      <tr v-for="backup in itemsPaginated" :key="backup.id">
        <TableCheckboxCell
          v-if="checkable"
          @checked="checked($event, backup)"
        />
        <td class="border-b-0 lg:w-6 before:hidden">
          <UserAvatar
            :icon="mdiDatabase"
            class="w-24 h-24 mx-auto lg:w-6 lg:h-6"
          />
        </td>
        <td data-label="Name">
          {{ new Date(backup.date).toLocaleString() }}
        </td>
        <td data-label="TeamName">
          {{ backup.sizeInBytes }}
        </td>
        <td data-label="Medals">
          {{ backup.path }}
        </td>
        <td class="before:hidden lg:w-1 whitespace-nowrap">
          <BaseButtons type="justify-start lg:justify-end" no-wrap>
            <BaseButton
              color="warning"
              :icon="mdiRestoreAlert"
              icon-size="25"
              small
              @click="warningRestoreBackup(backup)"
            />
            <BaseButton
              color="danger"
              :icon="mdiDelete"
              small
              @click="deleteBackup(backup)"
            />
          </BaseButtons>
        </td>
      </tr>
    </tbody>
  </table>
  <div
    v-show="itemsPaginated.length > 0"
    class="p-3 lg:px-6 border-t border-gray-100 dark:border-slate-800"
  >
    <BaseLevel>
      <BaseButtons v-show="numPages > 1">
        <BaseButton
          v-for="page in pagesList"
          :key="page"
          :active="page === currentPage"
          :label="page + 1"
          :color="page === currentPage ? 'lightDark' : 'whiteDark'"
          small
          @click="currentPage = page"
        />
      </BaseButtons>
      <small v-show="numPages > 1"
        >Page {{ currentPageHuman }} of {{ numPages }}</small
      >
    </BaseLevel>
  </div>
</template>
