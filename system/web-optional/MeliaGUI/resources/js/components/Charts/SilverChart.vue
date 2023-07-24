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
  scales: {
    x: {
      stacked: true, // Enable stacking for the x-axis (horizontal stacking)
    },
    y: {
      stacked: true, // Enable stacking for the y-axis (vertical stacking)
    },
  },
  plugins: {
    legend: {
      display: false, // Hide the legend (labels on top)
    },
  },
  barThickness: 25,
}

ChartJS.register(Title, Tooltip, Legend, BarElement, CategoryScale, LinearScale)

const chartData = {
  labels: [], // To store the team names (account names)
  datasets: [], // To store the datasets for each character's silver amount
}

// Create an array to store character names (for tooltips)
const characterNames = []

// Loop through each teamName (account)
for (const teamName in props.data) {
  if (props.data.hasOwnProperty(teamName)) {
    const characterData = props.data[teamName]

    // Add the teamName to the labels array (for x-axis)
    chartData.labels.push(teamName)

    // Loop through the character data for the current teamName (account)
    for (const characterName in characterData) {
      if (characterData.hasOwnProperty(characterName)) {
        // Check if the character is already added to the characterNames array
        // If not, add it to ensure correct tooltips
        if (!characterNames.includes(characterName)) {
          characterNames.push(characterName)
        }
      }
    }
  }
}

// Loop through each character to create datasets for each account (teamName)
for (const characterName of characterNames) {
  const dataset = {
    label: characterName,
    backgroundColor:
      '#' +
      (Math.random().toString(16) + '000000').substring(2, 8).toUpperCase(),
    data: [], // To store the silver amounts for each character within each account
  }

  // Loop through each teamName (account)
  for (const teamName in props.data) {
    if (props.data.hasOwnProperty(teamName)) {
      const characterData = props.data[teamName]

      // Add the character's silver amount to the dataset's data array for the current account (teamName)
      dataset.data.push(characterData[characterName] || 0) // If character does not exist in the account, use 0 silver
    }
  }

  // Add the dataset for the character to the datasets array
  chartData.datasets.push(dataset)
}
</script>

<template>
  <Bar :data="chartData" :style="chartStyle" :options="chartOptions" />
</template>
