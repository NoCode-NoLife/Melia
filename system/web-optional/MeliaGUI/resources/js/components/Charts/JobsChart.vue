<script setup>
import { Bar } from 'vue-chartjs'
import {
  Chart as ChartJS,
  Title,
  Tooltip,
  Legend,
  BarElement,
  CategoryScale,
  LinearScale,
} from 'chart.js'

const props = defineProps({
  data: {
    type: Object,
    required: true,
  },
})

const chartStyle = {
  height: '250px',
}

const chartOptions = {
  responsive: true,
  maintainAspectRatio: true,
  plugins: {
    legend: {
      display: false, // Hide the legend (labels on top)
    },
  },
  barThickness: 25,
  scales: {
    y: {
      beginAtZero: true,
      ticks: {
        stepSize: 1, // Display only integer values on the y-axis
      },
    },
  },
}

ChartJS.register(Title, Tooltip, Legend, BarElement, CategoryScale, LinearScale)

const chartData = {
  labels: Object.keys(props.data), // Use Object.keys to get the job names directly as labels
  datasets: [
    {
      borderRadius: {
        topLeft: 20,
        topRight: 20,
      },
      label: 'Count',
      backgroundColor: '#2563eb',
      data: Object.values(props.data), // Use Object.values to get the job counts directly as data points
    },
  ],
}
</script>

<template>
  <Bar :data="chartData" :style="chartStyle" :options="chartOptions" />
</template>
