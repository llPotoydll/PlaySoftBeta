import Vue from 'vue'
import Vuex from 'vuex'

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

  },
  getters: {
  },
  mutations: {
  },
  actions: {
  },
  modules: {
  }
})
