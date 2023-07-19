import forms from '@tailwindcss/forms';
const plugin = require("tailwindcss/plugin");

module.exports = {
  content: [
        './vendor/laravel/framework/src/Illuminate/Pagination/resources/views/*.blade.php',
        './storage/framework/views/*.php',
        './resources/views/**/*.blade.php',
        './resources/js/**/*.{vue,js,ts,jsx,tsx}',
    ],
    darkMode: "class", // or 'media' or 'class'
    theme: {
        extend: {
            screens: {
              'sm': '640px',
              'md': '768px',
              'lg': '1024px',
              'xl': '1280px',
              '2xl': '1536px',
            },
        },
    },
    plugins: [
        forms,
        plugin(function ({ matchUtilities, theme }) {
        matchUtilities(
            {
            "aside-scrollbars": (value) => {
                const track = value === "light" ? "100" : "900";
                const thumb = value === "light" ? "300" : "600";
                const color = value === "light" ? "gray" : value;

                return {
                scrollbarWidth: "thin",
                scrollbarColor: `${theme(`colors.${color}.${thumb}`)} ${theme(
                    `colors.${color}.${track}`
                )}`,
                "&::-webkit-scrollbar": {
                    width: "8px",
                    height: "8px",
                },
                "&::-webkit-scrollbar-track": {
                    backgroundColor: theme(`colors.${color}.${track}`),
                },
                "&::-webkit-scrollbar-thumb": {
                    borderRadius: "0.25rem",
                    backgroundColor: theme(`colors.${color}.${thumb}`),
                },
                };
            },
            },
            { values: theme("asideScrollbars") }
        );
        }),
    ],
};

