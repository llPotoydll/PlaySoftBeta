<template>
    <v-app id="inspire">
        <v-main class="pa-0">
            <section id="fondo" class="fondo1">
                <span v-for="(obj, index) in 900" :key="index">
                </span>
            </section>
            <v-container class="fill-height secciones" fluid style="justify-content: center;">
                <v-list>
                    <v-list-item v-for="item in items" :key="item.titles" :title="HOLA" subtitle="..."></v-list-item>
                </v-list>
            </v-container>
        </v-main>
    </v-app>
</template>

<script>
import axios from 'axios';

export default {
    name: 'SongsPage',
    data() {
        return {
            Songs:[]
        };
    },
    mounted: function () {
        console.log()
        console.log(sessionStorage.getItem("userid"))
        let vue = this;
        const playid = sessionStorage.getItem("playlistid")
        console.log(playid)

        axios.get(`https://localhost:7279/Playlist/songs/${playid}`)
            .then(function (response) {
                console.log(response);
                vue.Songs = response.data
            })
    }
}
</script>

<style>
v-content {
    display: flex;
    justify-content: center;
    align-items: center;
    min-height: 350vh;
    background-color: black;
    padding: none !important;
}

.secciones {
    flex-direction: column;
}

.text {
    z-index: 2;
    color: white;
    text-align: center;
}

.fondo1 {
    position: absolute;
    width: 100vw;
    height: 350vh;
    display: flex;
    justify-content: center;
    align-items: center;
    gap: 2px;
    flex-wrap: wrap;
    overflow: hidden;
    z-index: 0;
    background: gray;
}

section::before {
    content: '';
    position: absolute;
    width: 100%;
    height: 100%;
    background: linear-gradient(black, purple, black);
    animation: animate 15s linear infinite;
}

@keyframes animate {
    0% {
        transform: translateY(-100%);
    }

    100% {
        transform: translateY(100%);
    }
}

section span {
    position: relative;
    display: block;
    width: calc(6.25vw - 2px);
    height: calc(6.25vw - 2px);
    background-color: rgb(15, 15, 15);
    z-index: 2;
    transition: 1.5s;
}

section span:hover {
    background: rgb(128, 0, 128);
    transition: 0s;
}

@media(max-width: 900px) {
    section span {
        width: calc(10vw- 2px);
        height: calc(10vw - 2px);
    }
}

@media(max-width: 600px) {
    section span {
        width: calc(20vw- 2px);
        height: calc(20vw - 2px);
    }
}
</style>