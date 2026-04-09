import { deleteHotel } from "../api/hotelService";

function HotelList() {
    const [hotels, setHotels] = React.useState([]);

    const fetchHotels = async () => {
        const data = await getAllHotels();
        setHotels(data);
    }

    useEffect(() => {
        fetchHotels();
    }, []);

    const handleDelete = async (id) => {
        await deleteHotel(id);
        fetchHotels();
    }

    return (
        <div>
            <h2>Hotels</h2>
            <Link to="/create">Add Hotel</Link>

            <ul>
                {hotels.map((h) => (
                    <li key={h.id}>
                        {h.name}
                        <Link to ={`/hotel/${h.id}`}>View</Link>
                        <Link to ={`/edit/${h.id}`}>Edit</Link>
                        <button onClick={() => handleDelete(h.id)}>Delete</button>
                    </li>
                ))}
            </ul>
        </div>
    );
}
export default HotelList;