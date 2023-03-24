<template>
    <div id="app" v-cloak style="min-height: 0px;">
        <v-app style="max-height: 0px;">

            <v-layout>
                <v-btn class="btn" @click="compose({})">Add Song</v-btn>
            </v-layout>

            <v-dialog v-model="$store.state.dialogComposeSong" width="500">
                <v-card>
                    <v-card-title class="headline purple" primary-title>
                        Add Song
                    </v-card-title>
                    <v-alert v-show="$store.state.errorSong" style="margin: 20px; color: white" color="error" icon="$error"
                        id="alert">{{
                            alertMessage }}</v-alert>
                    <v-card-text class="pa-5">

                        <v-form ref="sendForm" v-model="$store.state.validSong" lazy-validation>
                            <v-text-field v-model="$store.state.songNameSong" label="Song name"
                                :rules="[rules.required]"></v-text-field>
                            <div v-html="composeMessage.originalBody"></div>
                            <div class="switch">
                            </div>
                        </v-form>
                        <div>
                            Añadir canciones
                        </div>
                    </v-card-text>
                    <v-card-actions class="pa-5">
                        <v-btn class="ml-auto" @click="saveDraft()" outlined color="primary">Cancel</v-btn>
                        <v-btn @click="addSong()" outlined color="primary">Save</v-btn>
                    </v-card-actions>
                </v-card>
            </v-dialog>
        </v-app>
    </div>
</template>
<script>
import axios from 'axios';
export default {
    data() {
        return {
            rules: {
                required: value => !!value || "This field is required",
                email: v => /.+@.+\..+/.test(v) || "Must be a valid email"
            }

        }

    },
    methods: {
        compose() {
            this.$store.state.dialogComposeSong = true
        },
        saveDraft() {
            this.$store.state.dialogComposeSong = false
            this.$store.state.errorSong = false
        },

        async addSong() {
            if (this.$store.state.songName != "") {

                const playid = sessionStorage.getItem("playlistid");
                console.log(playid);
                let song = await axios.get(`https://playsoft-api.azurewebsites.net/Song/search/${this.$store.state.songName}`).catch(e => {
                    this.$store.state.alertMessageSong = "This song doesn't exist";
                    this.$store.state.errorSong = true;
                    console.log(e);
                });

                if (song != null) {

                    console.log(song.data.songID);
                    axios.post('https://playsoft-api.azurewebsites.net/Song/addSong', {
                        playlistID: playid,
                        songID: song.data.songID,

                    })
                        .then(function (response) {
                            response.data
                            location.reload();
                        })
                        .catch(e => {
                            this.$store.state.alertMessageSong = "Playlist already have this song"
                            this.$store.state.errorSong = true;
                            console.log(e);
                        });
                    this.$store.state.errorSong = false
                }
            } else {
                this.$store.state.errorSong = true
                this.$store.state.alertMessageSong = "Name field is required"
            }
        }
    },
    mounted: function () {
    }
}
</script>
<style>
.switch {
    display: flex;
    gap: 30px;
}

.btn {
    margin-top: 150px;
    margin-left: 50px;
}
</style>
