import {
  mdiAccountCircle,
  mdiMonitor,
  mdiGithub,
  mdiLock,
  mdiAlertCircle,
  mdiSquareEditOutline,
  mdiTable,
  mdiViewList,
  mdiTelevisionGuide,
  mdiResponsive,
  mdiPalette,
  mdiReact,
} from "@mdi/js";

export default [
  {
    to: "",
    icon: mdiMonitor,
    label: "Dashboard",
  },
  {
    to: "",
    label: "Tables",
    icon: mdiTable,
  },
  {
    to: "",
    label: "Forms",
    icon: mdiSquareEditOutline,
  },
  {
    to: "",
    label: "UI",
    icon: mdiTelevisionGuide,
  },
  {
    to: "",
    label: "Responsive",
    icon: mdiResponsive,
  },
  {
    to: "",
    label: "Styles",
    icon: mdiPalette,
  },
  {
    to: "",
    label: "Profile",
    icon: mdiAccountCircle,
  },
  {
    to: "",
    label: "Login",
    icon: mdiLock,
  },
  {
    to: "",
    label: "Error",
    icon: mdiAlertCircle,
  },
  {
    label: "Dropdown",
    icon: mdiViewList,
    menu: [
      {
        label: "Item One",
      },
      {
        label: "Item Two",
      },
    ],
  },
  {
    href: "https://github.com/justboil/admin-one-vue-tailwind",
    label: "GitHub",
    icon: mdiGithub,
    target: "_blank",
  },
  {
    href: "https://github.com/justboil/admin-one-react-tailwind",
    label: "React version",
    icon: mdiReact,
    target: "_blank",
  },
];
