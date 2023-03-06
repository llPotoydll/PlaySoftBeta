import Vue from 'vue'
import App from './App.vue'
import vuetify from './plugins/vuetify'
import routers from './routers'
import VueCompositionAPI from '@vue/composition-api'

Vue.config.productionTip = false
Vue.use(VueCompositionAPI)

new Vue({
  vuetify,
  routers,
  VueCompositionAPI,
  render: h => h(App)
}).$mount('#app')
