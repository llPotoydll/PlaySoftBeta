import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [{
        path: '/',
        name: 'home',
        component: () =>
            import ('../views/HomeView.vue')
    },
    {
        path: '/login',
        name: 'login',
        component: () =>
            import ('../views/LoginView.vue')
    },
    {
        path: '/playlists',
        name: 'playlists',
        component: () =>
            import ('../views/PlaylistsView.vue')
    },
    {
        path: '/songs',
        name: 'songs',
        component: () =>
            import ('../views/SongsView.vue')
    }
]

const router = new VueRouter({
    mode: 'history',
    routes
})

export default router