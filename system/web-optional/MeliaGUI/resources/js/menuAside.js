import {
  mdiAccountCircle,
  mdiMonitor,
  mdiGithub,
} from "@mdi/js";

export default [
  {
    href: "/admin/dashboard",
    icon: mdiMonitor,
    label: "Dashboard",
  },
  {
    href: "/profile",
    label: "Profile",
    icon: mdiAccountCircle,
  },
  {
    href: "https://github.com/NoCode-NoLife/melia",
    label: "GitHub",
    icon: mdiGithub,
    target: "_blank",
  },
];
