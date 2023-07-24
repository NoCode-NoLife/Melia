<script setup>
import { computed, ref, watch, onMounted } from 'vue'
import { useStore } from 'vuex'
import { usePage } from '@inertiajs/vue3'
import numeral from 'numeral'

const props = defineProps({
  prefix: {
    type: String,
    default: null,
  },
  suffix: {
    type: String,
    default: null,
  },
  value: {
    type: Number,
    default: 0,
  },
  duration: {
    type: Number,
    default: 500,
  },
  showOnOffline: {
    type: Boolean,
    default: true,
  },
})

const store = useStore()
const isServerOnline = usePage().props.isServerOnline

const newValue = ref(0)

const newValueFormatted = computed(() =>
  newValue.value < 1000
    ? newValue.value
    : numeral(newValue.value).format('0,0'),
)

const value = computed(() => props.value)

const grow = (m) => {
  const v = Math.ceil(newValue.value + m)

  if (v > value.value) {
    newValue.value = value.value
    return false
  }

  newValue.value = v

  setTimeout(() => {
    grow(m)
  }, 25)
}

const growInit = () => {
  newValue.value = 0
  grow(props.value / (props.duration / 25))
}

watch(value, () => {
  growInit()
})

onMounted(() => {
  growInit()
})
</script>

<template>
  <div>
    {{ prefix
    }}{{
      !showOnOffline
        ? isServerOnline
          ? newValueFormatted
          : '--'
        : newValueFormatted
    }}{{ newValueFormatted <= 0 ? '' : suffix }}
  </div>
</template>
