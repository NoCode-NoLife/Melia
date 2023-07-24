<script setup>
import { computed, ref, getCurrentInstance } from 'vue'
import { mdiEye, mdiAccount, mdiCancel } from '@mdi/js'
import CardBoxModal from '@/components/CardBoxModal.vue'
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
})

const isModalActive = ref(false)

const isModalDangerActive = ref(false)

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

const bannedAccount = ref(null)
const detailAccount = ref(null)

const banAccountWarning = (userAccount) => {
  bannedAccount.value = userAccount
  isModalDangerActive.value = true
}

const showAccountDetail = (userAccount) => {
  detailAccount.value = userAccount
  isModalActive.value = true
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
  <CardBoxModal v-model="isModalActive" title="Sample modal">
    <p v-if="detailAccount">
      account {{ detailAccount.name }}
      {{
        detailAccount.teamName != null
          ? 'with the TeamName ' + detailAccount.teamName
          : ''
      }}
      has {{ detailAccount.characters }} characters.
    </p>
    <p v-if="detailAccount && detailAccount.highestCharacterLevel != 0">
      The highest character level is
      <b>{{ detailAccount.highestCharacterName }}</b> wich has level
      <b>{{ detailAccount.highestCharacterLevel }}</b>
    </p>
  </CardBoxModal>

  <CardBoxModal
    v-model="isModalDangerActive"
    title="Do you want to ban the account?"
    button="danger"
    has-cancel
  >
    <p v-if="bannedAccount">
      Once you press the button, the account
      <b class="text-lg">{{ bannedAccount.name }}</b
      >{{ bannedAccount.teamName != null ? ' and Team Name ' : ''
      }}<b class="text-lg">{{
        bannedAccount.teamName != null ? bannedAccount.teamName : ''
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
        <th>Login</th>
        <th>TeamName</th>
        <th>Medals</th>
        <th>Created</th>
        <th />
      </tr>
    </thead>
    <tbody>
      <tr v-for="userAccount in itemsPaginated" :key="userAccount.id">
        <TableCheckboxCell
          v-if="checkable"
          @checked="checked($event, userAccount)"
        />
        <td class="border-b-0 lg:w-6 before:hidden">
          <UserAvatar
            :icon="mdiAccount"
            class="w-24 h-24 mx-auto lg:w-6 lg:h-6"
          />
        </td>
        <td data-label="Name">
          {{ userAccount.name }}
        </td>
        <td data-label="TeamName">
          {{ userAccount.teamName }}
        </td>
        <td data-label="Medals">
          {{ userAccount.medals }}
        </td>
        <td data-label="Created" class="lg:w-1 whitespace-nowrap">
          <small
            class="text-gray-500 dark:text-slate-400"
            :title="userAccount.created_at"
            >{{ new Date(userAccount.created_at).toLocaleString() }}</small
          >
        </td>
        <td class="before:hidden lg:w-1 whitespace-nowrap">
          <BaseButtons type="justify-start lg:justify-end" no-wrap>
            <BaseButton
              color="info"
              :icon="mdiEye"
              small
              @click="showAccountDetail(userAccount)"
            />
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
        <button
          class="inline-flex justify-center items-center whitespace-nowrap focus:outline-none transition-colors focus:ring duration-150 border cursor-pointer rounded border-white dark:border-slate-900 ring-gray-200 dark:ring-gray-500 bg-white text-black dark:bg-slate-900 dark:text-white hover:bg-gray-100 hover:dark:bg-slate-800 text-sm mr-3 last:mr-0 mb-3"
        >
          <span class="px-2">...</span>
        </button>
      </BaseButtons>
      <small v-show="numPages > 1"
        >Page {{ currentPageHuman }} of {{ numPages }}</small
      >
    </BaseLevel>
  </div>
</template>
