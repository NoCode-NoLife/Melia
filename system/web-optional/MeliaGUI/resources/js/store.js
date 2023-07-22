import { createStore } from 'vuex';
import * as styles from "@/styles.js";
import { darkModeKey, styleKey } from "@/config";

export const useStore = createStore({
  state() {
    return {
        account: null,
        IsServerOnline: false,

        /* Styles */
        asideStyle: "",
        asideScrollbarsStyle: "",
        asideBrandStyle: "",
        asideMenuItemStyle: "",
        asideMenuItemActiveStyle: "",
        asideMenuDropdownStyle: "",
        navBarItemLabelStyle: "",
        navBarItemLabelHoverStyle: "",
        navBarItemLabelActiveColorStyle: "",
        overlayStyle: "",

        /* Dark mode */
        darkMode: false,
    };
  },
  mutations: {
    setAccount(state, newValue) {
        state.account = newValue;
    },
    setIsServerOnline(state, newValue) {
        state.IsServerOnline = newValue;
    },
    setAccountWithPayload(state, payload) {
        if (payload.name) {
            state.account.name = payload.name;
        }
        if (payload.email) {
            state.account.email = payload.email;
        }
    },
    setStyle(state, payload) {
        if (!styles[payload]) {
            return;
        }

        if (typeof localStorage !== "undefined") {
            localStorage.setItem(styleKey, payload);
        }

        const style = styles[payload];

        for (const key in style) {
            state[`${key}Style`] = style[key];
        }
    },
    setDarkMode(state, payload = null) {
        state.darkMode = payload !== null ? payload : !state.darkMode;

        if (typeof localStorage !== "undefined") {
            localStorage.setItem(darkModeKey, state.darkMode ? "1" : "0");
        }

        if (typeof document !== "undefined") {
            document.body.classList[state.darkMode ? "add" : "remove"](
                "dark-scrollbars"
            );

            document.documentElement.classList[state.darkMode ? "add" : "remove"](
                "dark-scrollbars-compat"
            );
        }
    },
  },
  actions: {
    // Your actions here
  },
  getters: {
    // Your getters here
  },
});
