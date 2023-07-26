<script setup>
import BaseSection from '@/components/base/Section.vue'
import BaseAccordion from '@/components/base/Accordion.vue'
import BaseButton from '@/components/base/Button.vue'
import LandingBuyTradeImage from '@/components/landing/BuyTradeImage.vue'
import LandingExchange from '@/components/landing/Exchange.vue'
import LandingListItem from '@/components/landing/ListItem.vue'
import LandingPartnerImage from '@/components/landing/PartnerImage.vue'
import LandingStep from '@/components/landing/Step.vue'
import LandingTradingToolImage from '@/components/landing/TradingToolImage.vue'
import HomePageLayout from '@/Layouts/HomePageLayout.vue'

const props = defineProps({
  appName: {
    type: Array,
    required: true,
  },
})
</script>

<template>
  <HomePageLayout>
    <div class="w-full">
      <section id="hero" class="w-full">
        <BaseSection>
          <div
            class="col-span-12 lg:col-span-6 mt-12 xl:mt-10 space-y-4 sm:space-y-6 px-6 text-center sm:text-left"
          >
            <span
              data-aos="fade-right"
              data-aos-once="true"
              class="text-base text-gradient font-semibold uppercase"
              >Sign Up Today</span
            >
            <h1
              data-aos="fade-right"
              data-aos-once="true"
              class="text-[2.5rem] sm:text-5xl xl:text-6xl font-bold leading-tight capitalize sm:pr-8 xl:pr-10"
            >
              server software for
              <span class="text-header-gradient">Tree Of Savior</span>
            </h1>
            <p
              data-aos="fade-down"
              data-aos-once="true"
              data-aos-delay="300"
              class="paragraph hidden sm:block"
            >
              The server is solely being developed for educational purposes,
              learning about programming, MMORPGs
            </p>
            <div
              data-aos="fade-up"
              data-aos-once="true"
              data-aos-delay="700"
              class="flex flex-col sm:flex-row space-y-4 sm:space-y-0 sm:space-x-4 mt-2"
            >
              <BaseButton
                class="max-w-full px-8 py-4 bg-gradient-to-r from-[#468ef9] to-[#0c66ee] border border-[#0c66ee] text-white"
              >
                Get Started
              </BaseButton>
              <BaseButton
                class="max-w-full px-6 py-4 bg-inherit text-gradient border border-[#0c66ee] flex items-center justify-center"
              >
                <span>Download App</span>
                <ChevronDownIcon :size="20" class="mt-1 text-[#0c66ee]" />
              </BaseButton>
            </div>
          </div>
          <div class="hidden sm:block col-span-12 lg:col-span-6">
            <div class="w-full">
              <img
                data-aos="fade-up"
                data-aos-once="true"
                src="/assets/img/brain-cogs.png"
                class=""
                alt=""
              />
            </div>
          </div>
        </BaseSection>
      </section>

      <section class="w-full my-12">
        <div
          class="relative max-w-screen-xl px-8 mx-auto grid grid-cols-12 gap-x-6"
        >
          <div data-aos="fade-right" class="col-span-12 lg:col-span-6">
            <div class="w-full">
              <img src="/assets/img/development.png" alt="development" />
            </div>
          </div>
          <div
            data-aos="fade-left"
            class="col-span-12 lg:col-span-5 space-y-8 sm:space-y-6 mt-8 xl:px-8"
          >
            <h2 class="text-4xl font-semibold">State of Development</h2>
            <ul class="space-y-8 sm:space-y-4">
              <LandingListItem title="Active development">
                <p class="text-sm text-gray-700 leading-relaxed">
                  After years of inactivity, Melia is currently in semi-active
                  development again. The server is functional, but it can't be
                  called "playable" yet, as many features and especially the
                  content are still missing.
                </p>
              </LandingListItem>
              <LandingListItem title="Requirements">
                <p class="text-sm text-gray-700 leading-relaxed">
                  InnoDB compatible server, such as: MySQL 5 or MariaDB 10. .NET
                  4.6.2 Runtime on Windows or Mono 5 on Linux
                </p>
              </LandingListItem>
              <LandingListItem title="Installation">
                <p class="text-sm text-gray-700 leading-relaxed">
                  Compile Melia Run sql/main.sql to setup the database Copy
                  system/conf/database.conf to user/conf/, adjust the necessary
                  values and remove the rest.
                </p>
              </LandingListItem>
            </ul>
          </div>
        </div>
      </section>

      <section
        class="bg-partner relative max-w-full sm:mx-6 my-24 shadow sm:rounded-2xl overflow-hidden"
      >
        <div
          class="w-full px-6 sm:px-0 py-12 flex flex-col items-center justify-center space-y-2 text-center"
        >
          <h3
            data-aos="flip-down"
            class="text-2xl text-neutral-800 font-semibold"
          >
            Top contributors
          </h3>
          <p data-aos="flip-down" class="paragraph">
            The top persons that made more commits accepted to the github
            repository
          </p>
          <div
            data-aos="fade-up"
            class="flex flex-wrap items-center justify-center"
          >
            <div class="container mx-auto px-4 flex flex-wrap">
              <div class="w-full md:w-1/5 p-4">
                <div
                  class="max-w-md py-4 px-8 bg-white shadow-lg rounded-lg my-10 min-w-1/4"
                >
                  <div class="flex justify-center -mt-16">
                    <img
                      class="w-20 h-20 object-cover rounded-full border-4 border-[#4A8FF6]"
                      src="/assets/img/github/exec.png"
                    />
                  </div>
                  <div class="p-2">
                    <p class="mt-2 text-gray-600">2.5k commits</p>
                  </div>
                  <div class="flex justify-end mt-4">
                    <a
                      href="https://github.com/exectails"
                      class="text-xl font-medium text-[#4A8FF6]"
                      >Exec</a
                    >
                  </div>
                </div>
              </div>
              <div class="w-full md:w-1/5 p-4">
                <div
                  class="max-w-md py-4 px-8 bg-white shadow-lg rounded-lg my-10 min-w-1/4"
                >
                  <div class="flex justify-center -mt-16">
                    <img
                      class="w-20 h-20 object-cover rounded-full border-4 border-[#4A8FF6]"
                      src="/assets/img/github/SalmanTKhan.png"
                    />
                  </div>
                  <div class="p-2">
                    <p class="mt-2 text-gray-600">85+ commits</p>
                  </div>
                  <div class="flex justify-end mt-4">
                    <a
                      href="https://github.com/SalmanTKhan"
                      class="text-xl font-medium text-[#4A8FF6]"
                      >SalmanTKhan</a
                    >
                  </div>
                </div>
              </div>
              <div class="w-full md:w-1/5 p-4">
                <div
                  class="max-w-md py-4 px-8 bg-white shadow-lg rounded-lg my-10 min-w-1/4"
                >
                  <div class="flex justify-center -mt-16">
                    <img
                      class="w-20 h-20 object-cover rounded-full border-4 border-[#4A8FF6]"
                      src="/assets/img/github/kenedos.jpeg"
                    />
                  </div>
                  <div class="p-2">
                    <p class="mt-2 text-gray-600">17+ commits</p>
                  </div>
                  <div class="flex justify-end mt-4">
                    <a
                      href="https://github.com/kenedos"
                      class="text-xl font-medium text-[#4A8FF6]"
                      >Exec</a
                    >
                  </div>
                </div>
              </div>
              <div class="w-full md:w-1/5 p-4">
                <div
                  class="max-w-md py-4 px-8 bg-white shadow-lg rounded-lg my-10 min-w-1/4"
                >
                  <div class="flex justify-center -mt-16">
                    <img
                      class="w-20 h-20 object-cover rounded-full border-4 border-[#4A8FF6]"
                      src="/assets/img/github/Tachiorz.png"
                    />
                  </div>
                  <div class="p-2">
                    <p class="mt-2 text-gray-600">17+ commits</p>
                  </div>
                  <div class="flex justify-end mt-4">
                    <a
                      href="https://github.com/Tachiorz"
                      class="text-xl font-medium text-[#4A8FF6]"
                      >Tachiorz</a
                    >
                  </div>
                </div>
              </div>
              <div class="w-full md:w-1/5 p-4">
                <div
                  class="max-w-md py-4 px-8 bg-white shadow-lg rounded-lg my-10 min-w-1/4"
                >
                  <div class="flex justify-center -mt-16">
                    <img
                      class="w-20 h-20 object-cover rounded-full border-4 border-[#4A8FF6]"
                      src="/assets/img/github/felipecastagnaro.jpeg"
                    />
                  </div>
                  <div class="p-2">
                    <p class="mt-2 text-gray-600">14+ commits</p>
                  </div>
                  <div class="flex justify-end mt-4">
                    <a
                      href="https://github.com/felipecastagnarodecarvalho"
                      class="text-xl font-medium text-[#4A8FF6]"
                      >Castagnaro</a
                    >
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>

      <div class="w-full my-10 flex justify-center">
        <a
          v-smooth-scroll
          data-aos="flip-down"
          data-aos-delay="150"
          href="#navbar"
          class="px-6 py-3 flex items-center space-x-2 bg-[#FAFAFA] hover:bg-gray-100 hover:shadow-md border border-[#DDDDDD] rounded-md text-gray-700"
        >
          <span>Back to top</span>
          <ArrowUpIcon :size="20" />
        </a>
      </div>
    </div>
  </HomePageLayout>
</template>

<script>
import aosMixin from '@/mixins/aos'
export default {
  name: 'IndexPage',
  mixins: [aosMixin],
  data() {
    return {
      selected: 0,
      dropdownConcurency: false,
      dropdownCrypto: false,
      currencySelected: {
        img: 'country-icon/eng.png',
        name: 'USD',
      },
      currencies: [
        {
          img: 'country-icon/eng.png',
          name: 'USD',
        },
      ],
      cryptoSelected: {
        img: 'crypto-icon/bitcoin.png',
        name: 'BTC',
      },
      cryptocurrencies: [
        {
          img: 'crypto-icon/bitcoin.png',
          name: 'BTC',
        },
      ],
      trendings: [
        {
          id: 1,
          name: 'Bitcoin',
          price: 43180.13,
          logo: 'bitcoin.png',
          increase: true,
          data: [40, 35, 60, 75, 60, 75, 50],
        },
        {
          id: 2,
          name: 'Ethereum',
          price: 3480.65,
          logo: 'ethereum.png',
          increase: false,
          data: [25, 30, 60, 50, 80, 55, 80],
        },
        {
          id: 3,
          name: 'Solana',
          price: 150.2,
          logo: 'solana.png',
          increase: true,
          data: [40, 45, 40, 80, 50, 60, 35],
        },
        {
          id: 4,
          name: 'Dogecoin',
          price: 0.1572,
          logo: 'dogecoin.png',
          increase: true,
          data: [35, 70, 60, 80, 50, 60, 40],
        },
      ],
      topGainers: [
        {
          id: 1,
          name: 'PAPPAY',
          price: 0.00374,
          logo: 'pappay.png',
          increase: true,
          data: [30, 50, 45, 60, 70, 40, 45],
        },
        {
          id: 2,
          name: 'Bitcoin Asia',
          price: 0.02096,
          logo: 'bitcoin-asia.png',
          increase: true,
          data: [25, 60, 50, 60, 35, 50, 70],
        },
        {
          id: 3,
          name: 'MoonRock',
          price: 0.004907,
          logo: 'moonrock.png',
          increase: true,
          data: [40, 35, 40, 25, 50, 70, 45],
        },
        {
          id: 4,
          name: 'NinjaFloki',
          price: 0.000123,
          logo: 'ninjafloki.png',
          increase: true,
          data: [45, 35, 40, 30, 25, 45, 35],
        },
      ],
      recents: [
        {
          id: 1,
          name: 'MetaCraft',
          price: 0.0608,
          logo: 'metacraft.png',
          increase: false,
          data: [40, 50, 45, 60, 35, 40, 45],
        },
        {
          id: 2,
          name: 'Frog',
          price: 0.5875,
          logo: 'frog.png',
          increase: false,
          data: [25, 50, 45, 48, 40, 60, 45],
        },
        {
          id: 3,
          name: 'Musk Doge',
          price: 0.04041,
          logo: 'musk-doge.png',
          increase: true,
          data: [25, 35, 60, 45, 50, 45, 45],
        },
        {
          id: 4,
          name: '2SHARE',
          price: 1366.24,
          logo: '2share.png',
          increase: true,
          data: [35, 30, 60, 50, 35, 45, 40],
        },
      ],
      accordions: [
        {
          title: 'Why should I choose NEFA?',
          description:
            "We're industry pioneers, having been in the cryptocurrency industry since 2016. We've facilitated more than 21 billion USD worth of transactions on our exchange for customers in over 40 countries. Today, we're trusted by over 8 million customers around the world and have received praise for our easy-to-use app, secure wallet, and range of features.",
        },
        {
          title: 'How secure is NEFA?',
          description:
            "We're industry pioneers, having been in the cryptocurrency industry since 2016. We've facilitated more than 21 billion USD worth of transactions on our exchange for customers in over 40 countries. Today, we're trusted by over million customers around the world and have received praise for our easy-to-use app, secure wallet, and range of features.",
        },
        {
          title: 'Do I have to buy a whole Bitcoin?',
          description:
            "We're industry pioneers, having been in the cryptocurrency industry since 2016. We've facilitated more than 21 billion USD worth of transactions on our exchange for customers in over 40 countries. Today, we're trusted by over million customers around the world and have received praise for our easy-to-use app, secure wallet, and range of features.",
        },
        {
          title: 'How do I actually buy Bitcoin?',
          description:
            "We're industry pioneers, having been in the cryptocurrency industry since 2016. We've facilitated more than 21 billion USD worth of transactions on our exchange for customers in over 40 countries. Today, we're trusted by over million customers around the world and have received praise for our easy-to-use app, secure wallet, and range of features.",
        },
      ],
      steps: [
        {
          img: 'sign-up.png',
          title: 'Sign Up',
          description:
            'Sign up for your free NEFA Wallet on web, iOS or Android and follow our easy process to set up your profile',
        },
        {
          img: 'fund.png',
          title: 'Fund',
          description:
            'Choose your preferred payment method such as bank transfer or credit card to top up your NEFA Wallet',
        },
        {
          img: 'buy-crypto.png',
          title: 'Buy Crypto',
          description:
            'Buy Bitcoin or Ethereum, then securely store it in your Wallet or send it on easily to your friends anywhere',
        },
      ],
    }
  },
}
</script>
<style scoped>
.text-header-gradient {
  background: rgb(57, 132, 244);
  background: linear-gradient(
    169.4deg,
    #3984f4 -6.01%,
    #0cd3ff 36.87%,
    #2f7cf0 78.04%,
    #0e65e8 103.77%
  );
  background-clip: text;
  -webkit-text-fill-color: transparent;
}
.bg-partner {
  background: url('../assets/img/partner/background.png');
  background-size: cover;
  background-position: center;
}
.bg-trading-tools {
  background: url('../assets/img/bg-trading-tools.webp');
  background-size: cover;
  background-position: center;
}
.max-h-0 {
  max-height: 0;
}
</style>
