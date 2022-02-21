<template>
  <BaseLayout>
    <template v-slot:left>
      <div class="card-offset">
        <div class="image-header zag" />
        <br />
        <div class="text-header m-32">Конференции</div>
        <div class="line"></div>
        <div class="text-article">Учавствуйте в любых конференциях или же создавайте свои. И помните наука, путь к просвящению.</div>
      </div>
    </template>
    <template>
      <div>
        <Card v-for="conference in conferences" :key="conference.id" :conference="conference" />
      </div>
    </template>
    <template v-slot:right>
      <div class="text-header m-16">Самые популярные</div>

      <v-divider class="mhor-16" />

      <MiniCard v-for="conference in topConferences" :key="conference.id" :conference="conference" :mini="true" />
    </template>
  </BaseLayout>
</template>

<script lang="ts">
import Vue from "vue";
import Card from "../components/ListItem.vue";
import MiniCard from "../components/MiniListItem.vue";
import BaseLayout from "../components/BaseLayout.vue";
import ConferenceService from "@/services/ConferenceService";
import Conference, { IConference } from "@/services/models/Conference";

export default Vue.extend({
  components: {
    Card,
    MiniCard,
    BaseLayout,
  },

  data() {
    return {
      conferences: Array<Conference>(),
    };
  },

  computed: {
    topConferences() {
      var conf = this.conferences.map((x) => x) as Array<Conference>;

      return conf
        .sort(function (a: Conference, b: Conference) {
          if (a.countParticipants < b.countParticipants) {
            return 1;
          }
          if (a.countParticipants > b.countParticipants) {
            return -1;
          }
          return 0;
        })
        .slice(0, 4);
    },
  },

  async mounted() {
    var a = (await ConferenceService.getConferences()) as any;
    this.conferences = a.data.map((x: IConference) => new Conference(x));
  },
});
</script>

<style>
.home {
  display: flex;
  background-color: #f7f8f9;
}

.card-offset {
  padding: 30px;
}

.image-header {
  display: inline-block;
  margin: 0 auto;
  height: 100px;
  width: 100px;
}

.zag {
  border-radius: 50%;
  background-color: #d97272;
}

.m-32 {
  margin: 32px;
}

.m-16 {
  margin: 16px;
}

.text-header {
  display: inline-block;
  font-family: Roboto;
  font-style: normal;
  font-weight: normal;
  font-size: 18px;
  line-height: 21px;
  color: #535556;
}

.text-article {
  width: 150px;
  margin: 30px auto;
  margin-bottom: 0;
  font-family: Roboto Regular;
  font-style: normal;
  font-weight: normal;
  font-size: 15px;
  text-align: center;
  color: #898989;
}

.line {
  height: 2px;
  background-color: #e6e7e7;
}

.v-application--wrap {
  min-height: 0 !important;
}

.main {
  width: 100%;
  margin-top: 40px;
  display: inline-block;
  background: #ffffff;
  border: 2px solid #e6e7e7;
  box-sizing: border-box;
  border-radius: 5px;
}
</style>
