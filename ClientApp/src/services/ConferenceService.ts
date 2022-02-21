import Conference from "@/services/models/Conference";
import axios from "axios";

const apiUrlPrefix = "/api/Conferences";

export default {
  async getConferences(): Promise<Conference[]> {
    return await axios.get(apiUrlPrefix);
  },

  async getConferenceById(id: number): Promise<Conference> {
    return await axios.get(apiUrlPrefix + "/" + id);
  }
};