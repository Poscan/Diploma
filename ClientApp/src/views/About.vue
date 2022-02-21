<template>
  <v-app>
    <BaseLayout class="mb-2">
      <template v-slot:left>
        <div class="card-offset">
          <div class="image-header">
            <img :src="conference.pictureUrl" height="100%" width="100%" />
          </div>
          <br />
          <div class="text-header m-16">{{ conference.name }}</div>
          <div class="line"></div>
          <div class="text-subheader mb-16">Участников: {{ conference.countParticipants }}</div>
          <v-btn class="sign-up" color="primary"> Подать заявку </v-btn>
        </div>
      </template>
      <template>
        <v-app>
          <v-card class="mx-auto max-width" outlined>
            <v-card-title>
              <v-list-item two-line>
                <v-list-item-avatar size="150">
                  <img :src="conference.pictureUrl" height="100%" width="100%" />
                </v-list-item-avatar>
                <v-list-item-content>
                  <v-list-item-title class="text-h5 mb-1">
                    {{ conference.name }}
                  </v-list-item-title>
                  <v-list-item-subtitle class="text-h6">
                    {{ conference.organisationName }}
                  </v-list-item-subtitle>
                </v-list-item-content>
              </v-list-item>
            </v-card-title>

            <v-divider class="line" />

            <v-card-text class="p-32 pt-16">
              <span class="text-header"> Организатор: </span>
              {{ conference.owner.fullName }}
            </v-card-text>

            <v-divider class="line" />

            <v-card-text class="p-32 pt-16"> <span class="text-header"> Описание: </span> <span v-html="conference.description" /> </v-card-text>

            <v-divider class="line" />

            <v-card-text class="pt-16">
              <div style="margin-left: 16px" class="text-header">Доклады</div>
              <div class="container-flex">
                <ReportCard v-for="index in 4" :key="index" />
              </div>
            </v-card-text>
          </v-card>
        </v-app>
      </template>
      <template v-slot:right>
        <div class="mb-16">
          <div class="text-header m-16">Заявленные темы</div>
          <div class="line"></div>
          <div v-for="n in 10" :key="n">Тема доклада</div>
        </div>
      </template>
    </BaseLayout>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";
import Conference from "@/services/models/Conference";
import ConferenceService from "@/services/ConferenceService";
import BaseLayout from "../components/BaseLayout.vue";
import ReportCard from "../components/ReportCard.vue";

export default Vue.extend({
  components: {
    BaseLayout,
    ReportCard,
  },

  data() {
    return {
      conference: new Conference(),
    };
  },

  async mounted() {
    var id = this.$route.params.id;

    var response = (await ConferenceService.getConferenceById(Number.parseInt(id))) as any;
    this.conference = new Conference(response.data);
  },
});
</script>

<style scoped>
.container-flex {
  display: flex;
  flex-wrap: wrap;
}

.mb-16 {
  margin-bottom: 16px !important;
}

.p-16 {
  padding: 16px;
}

.p-32 {
  padding: 32px;
}

.pt-16 {
  padding-top: 16px !important;
}
</style>
