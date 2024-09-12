import React, {useState} from 'react';

type Props = {}

const Search : React.FC<Props> = (props: Props): JSX.Element => {
    const [search, setSearch] = useState<string>("");

    const onClick = (e: any) => {
        setSearch(e.target.value);
        console.log(e)
    }
    return (
        <div>
            <input type="text" name="" id="" value={search} onChange={(e) => onClick(e)}/>
        </div>
    )
}

export default Search;
