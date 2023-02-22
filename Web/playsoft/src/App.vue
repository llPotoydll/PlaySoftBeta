<template>
  <v-app>
    <CabeceraPlaysoft></CabeceraPlaysoft>
    <LoginCard></LoginCard>
  </v-app>
</template>

<script>

import CabeceraPlaysoft from './components/CabeceraPlaysoft.vue'
import LoginCard from './components/LoginCard.vue'

export default {
  name: 'App',

  components: {
    CabeceraPlaysoft,LoginCard
  },

  data: () => ({
    //
  }),
};
</script>
