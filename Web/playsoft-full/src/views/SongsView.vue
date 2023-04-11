<template>
    <div>
        <CabeceraPlaysoft></CabeceraPlaysoft>
        <SongListado></SongListado>
        <SearchBar></SearchBar>
    </div>
</template>

<script>
import CabeceraPlaysoft from '@/components/CabeceraPlaysoft.vue';
import SongListado from '@/components/SongListado.vue';
import SearchBar from '@/components/SearchBar.vue';

export default {
    name: 'HomeView',
    components: {
        CabeceraPlaysoft, SongListado, SearchBar
    }
}
</script>