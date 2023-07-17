import { createStore } from 'vuex';

const store = createStore({
  state() {
    return {
      account: null,
    };
  },
  mutations: {
    setAccount(state, newValue) {
        state.account = newValue;
    },
  },
  actions: {
    // Your actions here
  },
  getters: {
    // Your getters here
  },
});

export default store;
