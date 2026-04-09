import axios from "axios";

const BASE_URL = "http://localhost:7055/api/hotels";

export const getAllHotels = async () => {
  const res = await axios.get(`${BASE_URL}/GetAllHotels`);
  return res.data;
};

export const getHotelById = async (id) => {
  const res = await axios.get(`${BASE_URL}/${id}`);
  return res.data;
};

export const createHotel = async (data) => {
  const res = await axios.post(`${BASE_URL}/CreateHotel`, data);
  return res.data;
};

export const updateHotel = async (id, data) => {
  await axios.put(`${BASE_URL}/${id}`, data);
};

export const deleteHotel = async (id) => {
  await axios.delete(`${BASE_URL}/${id}`);
};