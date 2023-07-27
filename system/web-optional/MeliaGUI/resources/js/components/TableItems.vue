<script setup>
import { computed, ref, getCurrentInstance } from 'vue'
import { mdiTagText, mdiDelete } from '@mdi/js'
import { router } from '@inertiajs/vue3'
import CardBoxModal from '@/components/CardBoxModal.vue'
import TableCheckboxCell from '@/components/TableCheckboxCell.vue'
import BaseLevel from '@/components/BaseLevel.vue'
import BaseButtons from '@/components/BaseButtons.vue'
import BaseButton from '@/components/BaseButton.vue'
import UserAvatar from '@/components/UserAvatar.vue'
import FormControl from '@/components/FormControl.vue'
import FormField from '@/components/FormField.vue'

const props = defineProps({
  checkable: Boolean,
  isServerOnline: Boolean,
  items: {
    type: Array,
    required: true,
  },
  startLoading: {
    type: Function,
    required: true,
  },
  stopLoading: {
    type: Function,
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

const removingItem = ref(0)
const removingItemAmount = ref(0)
const warningCall = ref(null)

const removeItemWarning = (item) => {
  removingItem.value = item
  removingItemAmount.value = item.amount
  isModalDangerActive.value = true
  warningCall.value = () => {
    removeItem(item)
  }
}

const removeItem = (item) => {
  props.startLoading()
  isModalDangerActive.value = false
  router.post(
    route('admin.inventory.manager.remove.item'),
    {
      itemUniqueId: item.itemUniqueId,
      amount: removingItemAmount.value,
      characterId: item.characterId,
    },
    {
      preserveState: true,
      preserveScroll: false,
      onFinish: (visit) => {
        props.stopLoading()
      },
    },
  )
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
    title="Warning"
    button="danger"
    :confirm="warningCall"
    has-cancel
  >
    <p v-if="removingItem">
      Do you want to remove the
      <b class="text-lg">{{ removingItem.name }}</b
      >{{ removingItem.itemName }} from the {{ removingItem.characterName }} ?
    </p>
    <FormField label="Amount to be removed">
      <FormControl v-model="removingItemAmount" name="itemAmount" required />
    </FormField>
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
              :icon="mdiDelete"
              small
              @click="removeItemWarning(item)"
              :disabled="item.isCharacterOnline && isServerOnline"
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
