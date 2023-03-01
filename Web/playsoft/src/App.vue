<template>
  <v-app>
    <CabeceraPlaysoft></CabeceraPlaysoft>
    <v-content>
      <LoginCard></LoginCard>
    </v-content>
  </v-app>
</template>

<script>

import CabeceraPlaysoft from './components/CabeceraPlaysoft.vue'
import LoginCard from './components/LoginCard.vue'

export default {
  name: 'App',

  components: {
    CabeceraPlaysoft, LoginCard
  },

  data: () => ({
    //
  }),
};
</script>
