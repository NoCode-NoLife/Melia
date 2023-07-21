import {
  mdiAccountCircle,
  mdiMonitor,
  mdiGithub,
  mdiViewDashboard,
  mdiCogs,
} from "@mdi/js";

export default [
  {
    href: "/admin/dashboard",
    icon: mdiMonitor,
    label: "Administration",
    admin: true,
  },
  {
    href: "/admin/configs",
    icon: mdiCogs,
    label: "Configs",
    admin: false,
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
