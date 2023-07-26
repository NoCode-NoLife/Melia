<script setup>
import { computed, ref, getCurrentInstance } from 'vue'
import { mdiTagText, mdiCancel } from '@mdi/js'
import CardBoxModal from '@/components/CardBoxModal.vue'
import TableCheckboxCell from '@/components/TableCheckboxCell.vue'
import BaseLevel from '@/components/BaseLevel.vue'
import BaseButtons from '@/components/BaseButtons.vue'
import BaseButton from '@/components/BaseButton.vue'
import UserAvatar from '@/components/UserAvatar.vue'

const props = defineProps({
  checkable: Boolean,
  items: {
    type: Array,
    required: true,
  },
})

const isModalDangerActive = ref(false)

const perPage = ref(5)

const currentPage = ref(0)

const checkedRows = ref([])

const instance = getCurrentInstance()

console.log(instance.props.items)

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

const removeItem = ref(0)

const removeItemWarning = (itemId) => {
  removeItem.value = itemId
  isModalDangerActive.value = true
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
</script>

<template>
  <CardBoxModal
    v-model="isModalDangerActive"
    title="Do you want to ban the account?"
    button="danger"
    has-cancel
  >
    <p v-if="removeItem">
      Once you press the button, the account
      <b class="text-lg">{{ removeItem.name }}</b
      >{{ removeItem.teamName != null ? ' and Team Name ' : ''
      }}<b class="text-lg">{{
        removeItem.teamName != null ? removeItem.teamName : ''
      }}</b>
      will be banned from the server.
    </p>
  </CardBoxModal>

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
        <th>ItemName</th>
        <th>ItemId</th>
        <th>Amount</th>
        <th />
      </tr>
    </thead>
    <tbody>
      <tr v-for="item in itemsPaginated" :key="item.itemId">
        <TableCheckboxCell v-if="checkable" @checked="checked($event, item)" />
        <td class="border-b-0 lg:w-6 before:hidden">
          <UserAvatar
            :icon="mdiTagText"
            class="w-24 h-24 mx-auto lg:w-6 lg:h-6"
          />
        </td>
        <td data-label="ItemName">
          {{ item.itemName }}
        </td>
        <td data-label="ItemId">
          {{ item.itemId }}
        </td>
        <td data-label="Amount">
          {{ item.amount }}
        </td>
        <td class="before:hidden lg:w-1 whitespace-nowrap">
          <BaseButtons type="justify-start lg:justify-end" no-wrap>
            <BaseButton
              color="danger"
              :icon="mdiCancel"
              small
              @click="banAccountWarning(userAccount)"
            />
          </BaseButtons>
        </td>
      </tr>
    </tbody>
  </table>
  <div class="p-3 lg:px-6 border-t border-gray-100 dark:border-slate-800">
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
