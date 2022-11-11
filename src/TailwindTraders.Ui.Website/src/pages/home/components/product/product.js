import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Card from '@material-ui/core/Card';
import CardMedia from '@material-ui/core/CardMedia';
import CardContent from '@material-ui/core/CardContent';
import IconButton from '@material-ui/core/IconButton';
import Typography from '@material-ui/core/Typography';
import { red } from '@material-ui/core/colors';
import WishlistIcon from '../../../../assets/images/original/Contoso_Assets/Icons/wishlist_icon.svg'

const useStyles = makeStyles((theme) => ({
  root: {
    maxWidth: 345,
  },
  media: {
    height: 0,
    paddingTop: '56.25%', // 16:9
  },
  expand: {
    transform: 'rotate(0deg)',
    marginLeft: 'auto',
    transition: theme.transitions.create('transform', {
      duration: theme.transitions.duration.shortest,
    }),
  },
  expandOpen: {
    transform: 'rotate(180deg)',
  },
  avatar: {
    backgroundColor: red[500],
  },
}));

export default function Product(props) {
  const classes = useStyles();
  const  { prodImg, imageUrl, name, price } = props;
  return (
    <Card className="productCard">
      <CardMedia
        className={classes.media}
        image={prodImg?prodImg:imageUrl}
        title={name?name:''}
      />
      <CardContent>
        <div style={{display:'flex',alignItems:'center',marginBottom:'8.25px'}}>
            <Typography variant="h6" color="initial" component="h6" className='productName' style={{marginRight:'auto'}}>
                {name?name:'Lunar Shift Special Edition'}
            </Typography>
            <IconButton className='wishlist_icon' aria-label="add to favorites">
                <img src={WishlistIcon} alt="like"/>
            </IconButton>
        </div>
        <Typography variant="body2" color="textSecondary" component="p">
          Controller
        </Typography>
        <div style={{display:'flex',alignItems:'center',paddingTop:'10px'}}>
            <Typography variant="h6" color="initial" component="h6" style={{marginRight:'auto'}} className="productOrgPrice m-0 mr-1">
                ${price?price+'.00':'39.49'}
            </Typography>
            <Typography paragraph color="textSecondary" className="m-0 mr-1">
                $78.46
            </Typography>
            <Typography paragraph color="error" className="m-0 mr-1 ">
                50% OFF
            </Typography>
        </div>
      </CardContent>
    </Card>
  );
}