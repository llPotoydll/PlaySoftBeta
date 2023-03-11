<template>
    <v-app id="inspire">
        <v-main class="pa-0" style="z-index: 0;">
            <section id="fondo" class="fondo1">
                <span v-for="(obj, index) in 900" :key="index">
                </span>
            </section>
            <v-container class="fill-height secciones" fluid style="justify-content: center;">
                <v-card flat class="ma-3 text-xs-center justify-center carta" v-for="playlist in PlayLists" :key="playlist">
                    <v-card-title primary-title>
                        <div>
                            <button class="headline pink--text text--accent-2" @click="redirigir( playlist.playListName )">
                                {{ playlist.playListName }}</button>
                            <div>{{ playlist.playlistDescription }}</div>
                        </div>
                    </v-card-title>
                    <v-card-actions>
                        <v-btn flat color="purple">See songs</v-btn>
                    </v-card-actions>
                </v-card>
                <v-card flat class="ma-3 text-xs-center justify-center carta">
                    <v-card-title primary-title>
                        <div>
                            <v-btn rounded color="#6c176d" dark @click.prevent="ventana = true">NEW</v-btn>
                            <div v-bind="ventana" v-if="ventana">
                                <form action="">
                                    PlaylistName:<v-text-field type="text" v-model="playListName" />
                                    Description:<v-text-field type="text" v-model="playlistDescription" />
                                    private?<input type="checkbox" v-model="privacity" />
                                    <input type="button" @click.prevent="ventana = false" value="Create"
                                        style="background-color: blueviolet; border-radius: 10px;" @click="nuevaPl()">
                                </form>
                            </div>
                        </div>
                    </v-card-title>
                </v-card>
            </v-container>
        </v-main>
    </v-app>
</template>

<script>
import axios from 'axios';

export default {
    name: 'PlayList',
    props: ["productItem"],
    data() {
        return {
            PlayLists: [],
            playListName: "",
            playlistDescription: "",
            privacity: false,
            ukid: "",
            ventana: false
        }
    },
    mounted: async function () {
        const usuario = sessionStorage.getItem("userid");
        let vue = this;
        parseInt(usuario)
        axios.get(`https://localhost:7279/Playlist/${usuario}`)
            .then(function (response) {
                vue.PlayLists = response.data
                console.log(vue.PlayLists);
                console.log(response.data[0].playListName)
            })
            .catch(e => {
                this.loginError = true;
                this.alertMessage = "No playlists";
                console.log(e);
            });

    },
    methods: {
        async nuevaPl() {
            const usuario = sessionStorage.getItem("userid");
            console.log(this.playListName)
            console.log(this.playlistDescription)
            console.log(this.privacity)
            this.ukid = usuario;
            console.log(this.ukid)

            axios.post("https://localhost:7279/Playlist/NewPlaylist", {
                playListName: this.playListName,
                ukid: this.ukid,
                playlistDescription: this.playlistDescription,
                privacity: this.privacity
            })
                .then(function (response) {
                    response.data
                    location.reload();
                })
                .catch(e => {
                    this.loginError = true;
                    this.alertMessage = "Error create playlist";
                    console.log(e);
                });
        },
        redirigir(nombrepl) {
            let vue = this;
            console.log(nombrepl)
            for (let index = 0; index < vue.PlayLists.length; index++) {
                if(vue.PlayLists[index].playListName == nombrepl){
                    sessionStorage.setItem("playlistid", vue.PlayLists[index].playlistID);
                    location.href = "http://localhost:8080/Songs"
                }
            }
        }
    }

}

</script>

<style>
.carta {
    display: flex;
    flex-direction: column;
    align-items: center;
}

.secciones {
    flex-direction: row;
}

.text {
    z-index: 2;
    color: white;
    text-align: center;
}

section {
    position: absolute;
    width: 100vw;
    height: 350vh;
    display: flex;
    justify-content: center;
    align-items: center;
    gap: 2px;
    flex-wrap: wrap;
    overflow: hidden;
    z-index: -1;
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