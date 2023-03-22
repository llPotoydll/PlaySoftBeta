import Vue from 'vue'
import Vuex from 'vuex'
import VuexPersistence from 'vuex-persistedstate'
import axios from 'axios';


Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    logo: require('../assets/images/Logo.png'),
    comprobarUsuario: false,
    registerUsername: "",
    registerEmail: "",
    registerPassword: "",
    repeatPassword: "",
    loginEmail: "",
    loginPassword: "",
    alertMessage: "",
    registerError: false,
    loginError: false,
    step: 1,
    PlayLists: [],
    ventana: false,
    playListName: "",
    playlistDescription: "",
    privacity: true,
    ukid: "",
    error: false,
    messages: [],
    drafts: [],
    sent: [],
    dialogCompose: false,
    activeMessage: {},
    composeMessage: {},
    valid: true,
    Songs: [],
    Songs2: [],
    songName: "",
    errorSong: false,
    messagesSong: [],
    draftsSong: [],
    alertMessageSong: "",
    sentSong: [],
    dialogComposeSong: false,
    activeMessageSong: {},
    composeMessageSong: {},
    validSong: true,
    usuario: ""

  },
  getters: {
  },
  mutations: {
  },
  actions: {
    getPlaylists() {
      let IdUser = parseInt(this.state.usuario)
      console.log(IdUser)
      axios.get(`https://playsoft-api.azurewebsites.net/Playlist/${IdUser}`)
        .then(function (response) {
          this.state.PlayLists = response.data
          console.log(this.state.PlayLists);
          console.log(response.data)
        })
        .catch(e => {
          this.state.loginError = true;
          this.alertMessage = "No playlists";
          console.log(e);
        });
    }
  },
  modules: {
  }, 
  plugins: [
    new VuexPersistence({
      storage: window.localStorage
    }).plugin
  ]
})
