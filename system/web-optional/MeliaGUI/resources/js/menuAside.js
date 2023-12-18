import {
  mdiAccountCircle,
  mdiMonitor,
  mdiGithub,
  mdiViewDashboard,
  mdiCogs,
  mdiArchive,
} from '@mdi/js'

export default [
  {
    href: '/admin/dashboard',
    icon: mdiMonitor,
    label: 'Administration',
    admin: true,
  },
  {
    href: '/admin/configs',
    icon: mdiCogs,
    label: 'Configs',
    admin: true,
  },
  {
    href: '/admin/inventory/manager',
    icon: mdiArchive,
    label: 'Inventory',
    admin: true,
  },
  {
    href: '/profile',
    label: 'Profile',
    icon: mdiAccountCircle,
    admin: false,
  },
  {
    href: 'https://github.com/NoCode-NoLife/melia',
    label: 'GitHub',
    icon: mdiGithub,
    target: '_blank',
    admin: false,
  },
]
