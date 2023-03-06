<template>
  <v-app-bar app>

    <img :src="logo" class="logo">


    <div class="d-flex align-center">
      <h1 class="title"> PLAYSOFT </h1>
    </div>

    <v-spacer></v-spacer>
    <router-link to="/"> |
      <span class="mr-2" :class="item">Home</span>
    </router-link>
    <router-link to="/about"> |
      <span class="mr-2" :class="item">Login</span>
    </router-link>
  </v-app-bar>
</template>

<script>
export default {
  name: 'CabeceraPlaysoft',
  data: function () {
    return {
      logo: require('../assets/images/Logo.png'),
      menu: ('../Menu.vue')
    }
  }
}
</script>

<style>
a{
  text-decoration: none;
}
h1 {
  color: rgb(118, 9, 113);
}

.logo {
  width: 3rem;
}

span {
  color: rgb(118, 9, 113);
}
</style>