<template>
  <v-app-bar app>
    <router-link to="/playlists">
      <img :src="logo" class="logo">
    </router-link>

    <div class="d-flex align-center">
      <h1 class="title"> PLAYSOFT </h1>
    </div>

    <v-spacer></v-spacer>
    <router-link to="/">
      <span class="mr-2" :class="item">Home</span>
    </router-link>
    <router-link to="/about" v-if="!comprobarUsuario">
      <span class="mr-2" :class="item">Login</span>
    </router-link>
    <router-link to="/playlists" v-else-if="comprobarUsuario">
      <span class="mr-2" :class="item">hola</span>
    </router-link>

  </v-app-bar>
</template>

<script>
export default {
  name: 'CabeceraPlaysoft',
  data: function () {
    return {
      logo: require('../assets/images/Logo.png'),
      menu: ('../Menu.vue'),
      comprobarUsuario: false,
    }
  },
  mounted: function comprobarUsuario() {
    //Comprobar si hay usuario
    const usuario = sessionStorage.getItem("userid");
    console.log(usuario)
    if (usuario != null) {
      this.comprobarUsuario = true;
    } else {
      this.comprobarUsuario = false;
    }
  }
}
</script>

<style>
a {
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
  padding: 1rem;
}
</style>