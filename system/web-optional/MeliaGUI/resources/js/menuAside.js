import {
  mdiAccountCircle,
  mdiMonitor,
  mdiGithub,
  mdiViewDashboard,
} from "@mdi/js";

export default [
  {
    href: "/admin/dashboard",
    icon: mdiMonitor,
    label: "Administration",
    admin: true,
  },
  {
    href: "/dashboard",
    icon: mdiViewDashboard,
    label: "Dashboard",
    admin: false,
  },
  {
    href: "/profile",
    label: "Profile",
    icon: mdiAccountCircle,
    admin: false,
  },
  {
    href: "https://github.com/NoCode-NoLife/melia",
    label: "GitHub",
    icon: mdiGithub,
    target: "_blank",
    admin: false,
  },
];
